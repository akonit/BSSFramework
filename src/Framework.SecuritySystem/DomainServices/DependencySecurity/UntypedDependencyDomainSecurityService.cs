﻿using Framework.Persistent;
using Framework.QueryableSource;

namespace Framework.SecuritySystem;

public class UntypedDependencyDomainSecurityService<TPersistentDomainObjectBase, TDomainObject, TBaseDomainObject, TIdent,
                                                    TSecurityOperationCode> :

    DependencyDomainSecurityServiceBase<TPersistentDomainObjectBase, TDomainObject, TBaseDomainObject, TIdent, TSecurityOperationCode>

    where TPersistentDomainObjectBase : class, IIdentityObject<TIdent>
    where TDomainObject : class, TPersistentDomainObjectBase
    where TSecurityOperationCode : struct, Enum
    where TBaseDomainObject : class, TPersistentDomainObjectBase
{
    private readonly IQueryableSource<TPersistentDomainObjectBase> queryableSource;

    public UntypedDependencyDomainSecurityService(
        IDisabledSecurityProviderSource disabledSecurityProviderSource,
        IDomainSecurityService<TBaseDomainObject, TSecurityOperationCode> baseDomainSecurityService,
        IQueryableSource<TPersistentDomainObjectBase> queryableSource)

        : base(disabledSecurityProviderSource, baseDomainSecurityService)
    {
        this.queryableSource = queryableSource ?? throw new ArgumentNullException(nameof(queryableSource));
    }

    protected override ISecurityProvider<TDomainObject> CreateDependencySecurityProvider(ISecurityProvider<TBaseDomainObject> baseProvider)
    {
        return new UntypedDependencySecurityProvider<TPersistentDomainObjectBase, TDomainObject, TBaseDomainObject, TIdent>(
            baseProvider,
            this.queryableSource);
    }
}
