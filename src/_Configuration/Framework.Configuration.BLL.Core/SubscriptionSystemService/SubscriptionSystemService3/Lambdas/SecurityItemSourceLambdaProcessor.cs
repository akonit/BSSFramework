﻿using System;
using System.Collections.Generic;
using System.Linq;

using Framework.Configuration.Core;
using Framework.Configuration.Domain;
using Framework.Persistent;

using JetBrains.Annotations;

namespace Framework.Configuration.BLL.SubscriptionSystemService3.Lambdas
{
    /// <summary>
    /// Процессор лямбда-выражения типа "SecurityItem".
    /// </summary>
    /// <seealso cref="LambdaProcessor" />
    public class SecurityItemSourceLambdaProcessor<TBLLContext> : LambdaProcessor<TBLLContext>
        where TBLLContext : class
    {
        /// <summary>Создаёт экземпляр класса <see cref="SecurityItemSourceLambdaProcessor"/>.</summary>
        /// <param name="bllContext">Контекст бизнес-логики.</param>
        /// <param name="parserFactory">Фабрика парсеров лямбда-выражений.</param>
        public SecurityItemSourceLambdaProcessor(
            TBLLContext bllContext,
            IExpressionParserFactory parserFactory)
            : base(bllContext, parserFactory)
        {
        }

        /// <inheritdoc/>
        protected override string LambdaName => "SecurityItemSource";

        /// <summary>Исполняет указанное в подписке ламбда-выражение типа "SecurityItem".</summary>
        /// <typeparam name="T">Тип доменного объекта.</typeparam>
        /// <typeparam name="TSecurityItem">Тип доменного объекта контекста безопасности.</typeparam>
        /// <param name="securityItem">Участник контекста безопасности.</param>
        /// <param name="versions">Версии доменного объекта.</param>
        /// <returns>Результат исполнения лямбда-выражения.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// securityItem
        /// or
        /// versions
        /// </exception>
        /// <exception cref="ArgumentNullException">Аргумент
        /// securityItem
        /// или
        /// versions равен null.</exception>
        public virtual IEnumerable<TSecurityItem> Invoke<T, TSecurityItem>(
            [NotNull] SubscriptionSecurityItem securityItem,
            [NotNull] DomainObjectVersions<T> versions)
            where T : class
            where TSecurityItem : IIdentityObject<Guid>
        {
            if (securityItem == null)
            {
                throw new ArgumentNullException(nameof(securityItem));
            }

            if (versions == null)
            {
                throw new ArgumentNullException(nameof(versions));
            }

            var lambda = securityItem.Source;

            if (!DomainObjectCompliesLambdaRequiredMode(lambda, versions))
            {
                return Enumerable.Empty<TSecurityItem>();
            }

            var result = this.TryInvoke(
                securityItem,
                versions,
                (si, vs) => this.InvokeInternal<T, TSecurityItem>(si, versions));

            return result;
        }

        private IEnumerable<TSecurityItem> InvokeInternal<T, TSecurityItem>(
            SubscriptionSecurityItem securityItem,
            DomainObjectVersions<T> versions)
            where T : class
            where TSecurityItem : IIdentityObject<Guid>
        {
            var result = securityItem.Source.WithContext
                ? this.InvokeWithTypedContext<T, TSecurityItem>(securityItem, versions)
                : this.InvokeWithoutContext<T, TSecurityItem>(securityItem, versions);

            return result;
        }

        private IEnumerable<TSecurityItem> InvokeWithoutContext<T, TSecurityItem>(
            SubscriptionSecurityItem securityItem,
            DomainObjectVersions<T> versions)
            where T : class
            where TSecurityItem : IIdentityObject<Guid>
        {
            var @delegate = this.ParserFactory
                .GetBySubscriptionSecurityItemSource<T, TSecurityItem>()
                .GetDelegate(securityItem);

            var result = @delegate(versions.Previous, versions.Current);

            return result;
        }

        [UsedImplicitly]
        private IEnumerable<TSecurityItem> InvokeWithTypedContext<T, TSecurityItem>(
            SubscriptionSecurityItem securityItem,
            DomainObjectVersions<T> versions)
            where T : class
            where TSecurityItem : IIdentityObject<Guid>
        {
            IEnumerable<TSecurityItem> result;
            var funcValue = securityItem.Source.FuncValue;

            if (funcValue != null)
            {
                result = this.TryCast<IEnumerable<TSecurityItem>>(funcValue(this.BllContext, versions));
            }
            else
            {
                var @delegate = this.ParserFactory
                .GetBySubscriptionSecurityItemSource<TBLLContext, T, TSecurityItem>()
                .GetDelegate(securityItem);

                result = @delegate(this.BllContext, versions.Previous, versions.Current);
            }

            return result;
        }
    }
}
