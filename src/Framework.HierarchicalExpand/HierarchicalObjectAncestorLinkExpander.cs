﻿using System;
using System.Collections.Generic;
using System.Linq;

using Framework.Core;
using Framework.Persistent;
using Framework.QueryableSource;

using JetBrains.Annotations;

namespace Framework.HierarchicalExpand
{
    public class HierarchicalObjectAncestorLinkExpander<TPersistentDomainObjectBase, TDomainObject, TDomainObjectAncestorLink, TDomainObjectAncestorChildLink, TIdent> : IHierarchicalObjectExpander<TIdent>
        where TPersistentDomainObjectBase : class, IIdentityObject<TIdent>
        where TDomainObject : class, TPersistentDomainObjectBase, IHierarchicalPersistentDomainObjectBase<TDomainObject, TIdent>
        where TDomainObjectAncestorLink : class, TPersistentDomainObjectBase, IHierarchicalAncestorLink<TDomainObject, TDomainObjectAncestorChildLink, TIdent>
        where TDomainObjectAncestorChildLink : class, TPersistentDomainObjectBase, IHierarchicalToAncestorOrChildLink<TDomainObject, TIdent>
        where TIdent : struct
    {
        private readonly IQueryableSource<TPersistentDomainObjectBase> queryableSource;

        public HierarchicalObjectAncestorLinkExpander([NotNull] IQueryableSource<TPersistentDomainObjectBase> queryableSource)
        {
            this.queryableSource = queryableSource ?? throw new ArgumentNullException(nameof(queryableSource));
        }

        public IEnumerable<TIdent> Expand(IEnumerable<TIdent> idents, HierarchicalExpandType expandType)
        {
            if (idents == null) throw new ArgumentNullException(nameof(idents));

            if (idents is IQueryable<TIdent>)
            {
                return this.ExpandQueryable(idents as IQueryable<TIdent>, expandType);
            }
            else
            {
                return this.ExpandDefault(idents, expandType);
            }
        }

        public Dictionary<TIdent, TIdent> ExpandWithParents(IEnumerable<TIdent> idents, HierarchicalExpandType expandType)
        {
            return this.ExpandWithParentsImplementation(idents.ToHashSet(), expandType);
        }

        public Dictionary<TIdent, TIdent> ExpandWithParents(IQueryable<TIdent> idents, HierarchicalExpandType expandType)
        {
            return this.ExpandWithParentsImplementation(idents, expandType);
        }

        private Dictionary<TIdent, TIdent> ExpandWithParentsImplementation(IEnumerable<TIdent> idents, HierarchicalExpandType expandType)
        {
            return this.ExpandDomainObject(idents, expandType)
                       .Select(domainObject => new { Id = domainObject.Id, ParentId = (TIdent?)domainObject.Parent.Id })
                       .Distinct()
                       .ToDictionary(pair => pair.Id, pair => pair.ParentId.GetValueOrDefault());
        }

        private IQueryable<TDomainObject> ExpandDomainObject(
            IEnumerable<TIdent> idents,
            HierarchicalExpandType expandType)
        {
            switch (expandType)
            {
                case HierarchicalExpandType.None:

                    return from domainObject in this.queryableSource.GetQueryable<TDomainObject>()
                           where idents.Contains(domainObject.Id)
                           select domainObject;

                case HierarchicalExpandType.Children:

                    return from link in this.queryableSource.GetQueryable<TDomainObjectAncestorLink>()
                           where idents.Contains(link.Ancestor.Id)
                           select link.Child;

                case HierarchicalExpandType.Parents:

                    return from link in this.queryableSource.GetQueryable<TDomainObjectAncestorLink>()
                           where idents.Contains(link.Child.Id)
                           select link.Ancestor;

                case HierarchicalExpandType.All:

                    return from link in this.queryableSource.GetQueryable<TDomainObjectAncestorChildLink>()
                           where idents.Contains(link.Source.Id)
                           select link.ChildOrAncestor;

                default:
                    throw new ArgumentOutOfRangeException(nameof(expandType));
            }
        }

        private IEnumerable<TIdent> ExpandDefault(IEnumerable<TIdent> baseIdents, HierarchicalExpandType expandType)
        {
            if (baseIdents == null) throw new ArgumentNullException(nameof(baseIdents));

            var ancestorLinkQueryable = this.queryableSource.GetQueryable<TDomainObjectAncestorLink>();

            var idents = baseIdents.ToHashSet();

            switch (expandType)
            {
                case HierarchicalExpandType.None:

                    return idents;

                case HierarchicalExpandType.Children:

                    return ancestorLinkQueryable.Where(link => idents.Contains(link.Ancestor.Id)).Select(link => link.Child.Id);

                case HierarchicalExpandType.Parents:

                    return ancestorLinkQueryable.Where(link => idents.Contains(link.Child.Id)).Select(link => link.Ancestor.Id);

                case HierarchicalExpandType.All:

                    return this.queryableSource.GetQueryable<TDomainObjectAncestorChildLink>()
                               .Where(z => idents.Contains(z.Source.Id))
                               .Select(z => z.ChildOrAncestor.Id);

                default:
                    throw new ArgumentOutOfRangeException(nameof(expandType));
            }
        }

        private IQueryable<TIdent> ExpandQueryable(IQueryable<TIdent> idents, HierarchicalExpandType expandType)
        {
            if (idents == null) throw new ArgumentNullException(nameof(idents));

            var ancestorLinkQueryable = this.queryableSource.GetQueryable<TDomainObjectAncestorLink>();

            switch (expandType)
            {
                case HierarchicalExpandType.None:

                    return idents;

                case HierarchicalExpandType.Children:

                    return ancestorLinkQueryable.Where(link => idents.Contains(link.Ancestor.Id)).Select(link => link.Child.Id);

                case HierarchicalExpandType.Parents:

                    return ancestorLinkQueryable.Where(link => idents.Contains(link.Child.Id)).Select(link => link.Ancestor.Id);

                case HierarchicalExpandType.All:

                    return this.queryableSource.GetQueryable<TDomainObjectAncestorChildLink>()
                               .Where(z => idents.Contains(z.Source.Id))
                               .Select(z => z.ChildOrAncestor.Id);

                default:
                    throw new ArgumentOutOfRangeException(nameof(expandType));
            }
        }
    }
}
