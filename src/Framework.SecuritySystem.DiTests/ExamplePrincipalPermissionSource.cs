﻿using System;
using System.Collections.Generic;

namespace Framework.SecuritySystem.DiTests
{
    public class ExamplePrincipalPermissionSource : IPrincipalPermissionSource<Guid>
    {
        private readonly List<Dictionary<Type, List<Guid>>> permissions;

        public ExamplePrincipalPermissionSource(List<Dictionary<Type, List<Guid>>> permissions)
        {
            this.permissions = permissions;
        }

        public List<Dictionary<Type, List<Guid>>> GetPermissions()
        {
            return this.permissions;
        }
    }
}
