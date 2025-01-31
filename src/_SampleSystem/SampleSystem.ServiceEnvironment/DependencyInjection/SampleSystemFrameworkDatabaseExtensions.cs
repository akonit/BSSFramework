﻿using Framework.Authorization.Generated.DAL.NHibernate;
using Framework.Configuration.Generated.DAL.NHibernate;
using Framework.Core;
using Framework.DomainDriven;
using Framework.DomainDriven.NHibernate;
using Framework.DomainDriven.ServiceModel.IAD;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using nuSpec.Abstraction;
using nuSpec.NHibernate;

using SampleSystem.AuditDAL.NHibernate;
using SampleSystem.BLL;
using SampleSystem.Domain;
using SampleSystem.Generated.DAL.NHibernate;
using SampleSystem.ServiceEnvironment.Database;

namespace SampleSystem.ServiceEnvironment;

public static class SampleSystemFrameworkDatabaseExtensions
{
    public static IServiceCollection RegisterGeneralDatabaseSettings(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        return services.AddDatabaseSettings(connectionString)
                       .AddLegacyDatabaseSettings()
                       .RegistryGenericDatabaseVisitors()
                       .RegistryDatabaseVisitors()
                       .RegisterSpecificationEvaluator();
    }

    private static IServiceCollection RegisterSpecificationEvaluator(this IServiceCollection services)
    {
        return services.AddSingleton<ISpecificationEvaluator, NhSpecificationEvaluator>();
    }

    public static IServiceCollection AddDatabaseSettings(this IServiceCollection services, string connectionString, bool includeTypedAudit = true)
    {
        return services.AddDatabaseSettings(setupObj => setupObj.AddEventListener<DefaultDBSessionEventListener>()
                                                                .AddEventListener<SubscriptionDBSessionEventListener>()

                                                                .SetEnvironment<SampleSystemNHibSessionEnvironment>()

                                                                .AddMapping(AuthorizationMappingSettings.CreateDefaultAudit(string.Empty))
                                                                .AddMapping(ConfigurationMappingSettings.CreateDefaultAudit(string.Empty))

                                                                .Pipe(includeTypedAudit, s => s

                                                                                             .AddMapping(new SampleSystemSystemAuditMappingSettings(string.Empty))
                                                                                             .AddMapping(new SampleSystemSystemRevisionAuditMappingSettings(string.Empty)))


                                                                .AddMapping(new SampleSystemMappingSettings(new DatabaseName(string.Empty, "app"), connectionString)));
    }

    private static IServiceCollection RegistryDatabaseVisitors(this IServiceCollection services)
    {
        services.AddSingleton<IExpressionVisitorContainerItem, ExpressionVisitorContainerDomainIdentItem<PersistentDomainObjectBase, Guid>>();

        // For reports
        services.AddScoped<IExpressionVisitorContainerItem, ExpressionVisitorContainerODataItem<ISampleSystemBLLContext, PersistentDomainObjectBase, Guid>>();

        return services;
    }
}
