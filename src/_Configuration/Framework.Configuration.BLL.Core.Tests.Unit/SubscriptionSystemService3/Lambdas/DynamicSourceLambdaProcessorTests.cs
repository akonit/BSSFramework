﻿using System;
using System.Collections.Generic;
using System.Linq;

using AutoFixture;
using AutoFixture.Idioms;

using FluentAssertions;
using Framework.Configuration.BLL.SubscriptionSystemService3;
using Framework.Configuration.BLL.SubscriptionSystemService3.Lambdas;
using Framework.Configuration.Core;
using Framework.Configuration.Domain;
using Framework.DomainDriven.BLL.Security;
using Framework.ExpressionParsers;
using Framework.UnitTesting;

using NSubstitute.ExceptionExtensions;

using NUnit.Framework;

namespace Framework.Configuration.BLL.Core.Tests.Unit.SubscriptionSystemService3.Lambdas
{
    [TestFixture]
    public sealed class DynamicSourceLambdaProcessorTests : TestFixtureBase
    {
        private IExpressionParserFactory parserFactory;

        [SetUp]
        public void SetUp()
        {
            this.parserFactory = new ExpressionParserFactory(CSharpNativeExpressionParser.Compile);
            this.Fixture.Register(() => this.parserFactory);
        }

        [Test]
        public void PublicSurface_NullArguments_ArgumentNullException()
        {
            // Arrange
            var assertion = new GuardClauseAssertion(this.Fixture);

            // Act

            // Assert
            assertion.Verify(typeof(DynamicSourceLambdaProcessor<ITestBLLContext>));
        }

        [Test]
        public void Invoke_WithoutContext_FilterItemIdentity()
        {
            // Arrange
            var id = Guid.NewGuid();
            var versions = new DomainObjectVersions<string>("a", "b");
            var lambdaText = $"(prev, current) => new List<FilterItemIdentity>{{ new FilterItemIdentity(\"some name\", \"{id}\") }}";

            // Act
            var invokeResult = this.Invoke(versions, lambdaText, string.Empty);
            var fid = invokeResult.Single();

            // Assert
            fid.EntityName.Should().Be("some name");
            fid.Id.Should().Be(id);
        }

        [Test]
        public void Invoke_WithContext_FilterItemIdentity()
        {
            // Arrange
            var id = Guid.NewGuid();
            var versions = new DomainObjectVersions<string>("a", "b");
            var lambdaText = $"(context, prev, current) => new List<FilterItemIdentity>{{ new FilterItemIdentity(\"some name\", \"{id}\") }}";

            // Act
            var invokeResult = this.Invoke(versions, lambdaText, "some name");
            var fid = invokeResult.Single();

            // Assert
            fid.EntityName.Should().Be("some name");
            fid.Id.Should().Be(id);
        }

        [Test]
        public void Invoke_NoLambda_EmptyResult()
        {
            // Arrange
            var versions = new DomainObjectVersions<string>(null, "b");

            // Act
            var invokeResult = this.Invoke(versions, null, string.Empty);

            // Assert
            invokeResult.Should().HaveCount(0);
        }

        [Test]
        public void Invoke_NoPrevious_EmptyResult()
        {
            // Arrange
            var versions = new DomainObjectVersions<string>(null, "b");

            // Act
            var invokeResult = this.Invoke(versions, "(prev, current) => null", string.Empty);

            // Assert
            invokeResult.Should().HaveCount(0);
        }

        [Test]
        public void Invoke_NoCurrent_EmptyResult()
        {
            // Arrange
            var versions = new DomainObjectVersions<string>("a", null);

            // Act
            var invokeResult = this.Invoke(versions, "(prev, current) => null", string.Empty);

            // Assert
            invokeResult.Should().HaveCount(0);
        }

        [Test]
        public void Invoke_Error_CorrectException()
        {
            // Arrange
            var versions = new DomainObjectVersions<string>("a", "b");
            const string lambdaText = "(context, prev, current) => context.NonExistingProperty";

            // Act
            Action call = () => this.Invoke(versions, lambdaText, "Hello");

            // Assert
            call.Should().Throw<SubscriptionServicesException>();
        }

        private IEnumerable<FilterItemIdentity> Invoke<T>(
            DomainObjectVersions<T> versions,
            string lambdaString,
            string context) where T : class
        {
            // Arrange
            var lambda = this.Fixture
                .Build<SubscriptionLambda>()
                .With(l => l.Value, lambdaString)
                .With(l => l.RequiredModePrev, true)
                .With(l => l.RequiredModeNext, true)
                .With(c => c.WithContext, !string.IsNullOrEmpty(context))
                .Create();

            var subscription = this.Fixture
                .Build<Subscription>()
                .With(s => s.DynamicSource, lambdaString != null ? lambda : null)
                .Create();

            // Act
            var processor = new DynamicSourceLambdaProcessor<string>(context, this.parserFactory);
            return processor.Invoke(subscription, versions);
        }
    }
}
