﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using Framework.HierarchicalExpand;

namespace Framework.SecuritySystem.DiTests
{
    public class ExampleAuthorizationSystem : AuthorizationSystem<Guid>
    {
        public ExampleAuthorizationSystem(IPrincipalPermissionSource<Guid> principalPermissionSource, IHierarchicalObjectExpanderFactory<Guid> hierarchicalObjectExpanderFactory)
            : base(principalPermissionSource, hierarchicalObjectExpanderFactory)
        {
        }

        public override bool HasAccess<TSecurityOperationCode>(NonContextSecurityOperation<TSecurityOperationCode> securityOperation) => throw new NotImplementedException();

        public override IEnumerable<string> GetAccessors<TSecurityOperationCode>(TSecurityOperationCode securityOperationCode, Expression<Func<IPrincipal<Guid>, bool>> principalFilter) => throw new NotImplementedException();
    }
}
