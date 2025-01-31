﻿using Framework.DependencyInjection;
using Framework.DomainDriven.BLL.Security;
using Framework.DomainDriven.NHibernate;
using Framework.DomainDriven.Repository;
using Framework.DomainDriven.Repository.NotImplementedDomainSecurityService;
using Framework.HierarchicalExpand;
using Framework.Persistent;
using Framework.SecuritySystem;

using Microsoft.Extensions.DependencyInjection;

namespace Framework.DomainDriven.ServiceModel.IAD;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection RegisterGenericServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IAsyncDal<,>), typeof(NHibAsyncDal<,>));

        services.AddScoped(typeof(IRepositoryFactory<>), typeof(RepositoryFactory<>));
        services.AddScoped(typeof(IGenericRepositoryFactory<,>), typeof(GenericRepositoryFactory<,>));

        services.AddSingleton<IDBSessionEvaluator, DBSessionEvaluator>();

        services.RegisterAuthorizationSystem();

        services.AddSingleton<IDateTimeService>(DateTimeService.Default);

        services.AddScoped(typeof(INotImplementedDomainSecurityService<>), typeof(OnlyDisabledDomainSecurityService<>));

        return services;
    }

    public static IServiceCollection RegistryGenericDatabaseVisitors(this IServiceCollection services)
    {
        services.AddSingleton<IExpressionVisitorContainerItem, ExpressionVisitorContainerDomainIdentItem<Framework.Authorization.Domain.PersistentDomainObjectBase, Guid>>();
        services.AddSingleton<IExpressionVisitorContainerItem, ExpressionVisitorContainerDomainIdentItem<Framework.Configuration.Domain.PersistentDomainObjectBase, Guid>>();

        services.AddSingleton<IExpressionVisitorContainerItem, ExpressionVisitorContainerPersistentItem>();
        services.AddSingleton<IExpressionVisitorContainerItem, ExpressionVisitorContainerPeriodItem>();
        services.AddSingleton<IExpressionVisitorContainerItem, ExpressionVisitorContainerDefaultItem>();
        services.AddSingleton<IExpressionVisitorContainerItem, ExpressionVisitorContainerMathItem>();

        services.AddSingleton<IIdPropertyResolver, IdPropertyResolver>();

        services.AddScoped<IExpressionVisitorContainer, ExpressionVisitorAggregator>();

        return services;
    }

    public static IServiceCollection RegisterHierarchicalObjectExpander<TPersistentDomainObjectBase>(this IServiceCollection services)
            where TPersistentDomainObjectBase : class, IIdentityObject<Guid>
    {
        return services.AddSingleton<IHierarchicalRealTypeResolver, IdentityHierarchicalRealTypeResolver>()
                       .AddScoped<IHierarchicalObjectExpanderFactory<Guid>, HierarchicalObjectExpanderFactory<TPersistentDomainObjectBase, Guid>>();
    }

    private static IServiceCollection RegisterAuthorizationSystem(this IServiceCollection services)
    {
        return services.AddScopedFrom<IAuthorizationSystem, IAuthorizationSystem<Guid>>()

                       .AddSingleton<IDomainObjectIdentResolver, DomainObjectIdentResolver<Guid>>()
                       .AddSingleton<IAccessDeniedExceptionService, AccessDeniedExceptionService>()

                       .AddSingleton<IDisabledSecurityProviderSource, DisabledSecurityProviderSource>();
    }
}
