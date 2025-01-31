﻿using System.Linq.Expressions;

using Framework.Core;
using Framework.Persistent;
using Framework.QueryableSource;

namespace Framework.SecuritySystem
{
    public class DependencySecurityProvider<TPersistentDomainObjectBase, TDomainObject, TBaseDomainObject, TIdent> : ISecurityProvider<TDomainObject>

        where TDomainObject : class, TPersistentDomainObjectBase
        where TBaseDomainObject : class, TPersistentDomainObjectBase
        where TPersistentDomainObjectBase : class, IIdentityObject<TIdent>
    {
        private readonly Expression<Func<TDomainObject, TBaseDomainObject>> selector;

        private readonly IQueryableSource<TPersistentDomainObjectBase> queryableSource;

        private readonly ISecurityProvider<TBaseDomainObject> baseSecurityProvider;

        public DependencySecurityProvider(ISecurityProvider<TBaseDomainObject> baseSecurityProvider, Expression<Func<TDomainObject, TBaseDomainObject>> selector, IQueryableSource<TPersistentDomainObjectBase> queryableSource)
        {
            this.baseSecurityProvider = baseSecurityProvider ?? throw new ArgumentNullException(nameof(baseSecurityProvider));
            this.selector = selector ?? throw new ArgumentNullException(nameof(selector));
            this.queryableSource = queryableSource;
        }

        public IQueryable<TDomainObject> InjectFilter(IQueryable<TDomainObject> queryable)
        {
            var baseDomainObjSecurityQ = this.queryableSource.GetQueryable<TBaseDomainObject>().Pipe(this.baseSecurityProvider.InjectFilter);

            return queryable.Where(this.selector.Select(domainObj => baseDomainObjSecurityQ.Contains(domainObj)));
        }

        public AccessResult GetAccessResult(TDomainObject domainObject)
        {
            return this.baseSecurityProvider.GetAccessResult(this.selector.Eval(domainObject));
        }

        public bool HasAccess(TDomainObject domainObject)
        {
            return this.baseSecurityProvider.HasAccess(this.selector.Eval(domainObject));
        }

        public UnboundedList<string> GetAccessors(TDomainObject domainObject)
        {
            return this.baseSecurityProvider.GetAccessors(this.selector.Eval(domainObject));
        }
    }
}
