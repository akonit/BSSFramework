﻿using System;

using Framework.Authorization.BLL;
using Framework.Core;
using Framework.DomainDriven;
using Framework.DomainDriven.BLL;
using Framework.DomainDriven.BLL.Security;
using Framework.DomainDriven.BLL.Tracking;
using Framework.Notification;
using Framework.Security.Cryptography;
using Framework.Workflow.BLL;

using SampleSystem.Domain;

namespace SampleSystem.BLL
{
    public partial interface ISampleSystemBLLContext :

        ISecurityBLLContext<IAuthorizationBLLContext, PersistentDomainObjectBase, DomainObjectBase, Guid>,

        IWorkflowBLLContextContainer,

        ITrackingServiceContainer<PersistentDomainObjectBase>,

        ICryptServiceContainer<CryptSystem>,

        IImpersonateObject<ISampleSystemBLLContext>,

        ITypeResolverContainer<string>,

        Framework.DomainDriven.BLL.Configuration.IConfigurationBLLContextContainer<Framework.Configuration.BLL.IConfigurationBLLContext>,

        IDefaultHierarchicalBLLContext<PersistentDomainObjectBase, Guid>,

        IDateTimeServiceContainer
    {
    }
}
