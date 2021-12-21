﻿using System;

using Framework.SecuritySystem;

namespace Framework.DomainDriven.BLL.Security
{
    public interface IRootSecurityService<out TBLLContext, in TPersistentDomainObjectBase> : IBLLContextContainer<TBLLContext>, IDisabledSecurityProviderContainer<TPersistentDomainObjectBase>
    {
        ISecurityProvider<TDomainObject> GetSecurityProvider<TDomainObject>(BLLSecurityMode securityMode)
            where TDomainObject : class, TPersistentDomainObjectBase;

        /// <summary>
        /// Получение безопасности по доменному типу для выгрузки аттачментов
        /// </summary>
        /// <typeparam name="TDomainObject">Тип доменного объекта</typeparam>
        /// <param name="securityMode">Режим безопасности</param>
        /// <returns></returns>
        ISecurityProvider<TDomainObject> GetAttachmentSecurityProvider<TDomainObject>(BLLSecurityMode securityMode)
            where TDomainObject : class, TPersistentDomainObjectBase;
        ISecurityProvider<TDomainObject> GetNotImplementedSecurityProvider<TDomainObject>(object data)
            where TDomainObject : class, TPersistentDomainObjectBase;

        IDomainSecurityService<TDomainObject> GetDomainSecurityService<TDomainObject>()
            where TDomainObject : class, TPersistentDomainObjectBase;
    }

    public interface IRootSecurityService<out TBLLContext, in TPersistentDomainObjectBase, TSecurityOperationCode> : IRootSecurityService<TBLLContext, TPersistentDomainObjectBase>

        where TSecurityOperationCode : struct, Enum
    {
        ISecurityProvider<TDomainObject> GetSecurityProvider<TDomainObject>(SecurityOperation<TSecurityOperationCode> securityOperation)
            where TDomainObject : class, TPersistentDomainObjectBase;

        ISecurityProvider<TDomainObject> GetSecurityProvider<TDomainObject>(TSecurityOperationCode securityOperationCode)
            where TDomainObject : class, TPersistentDomainObjectBase;

        new IDomainSecurityService<TDomainObject, TSecurityOperationCode> GetDomainSecurityService<TDomainObject>();
    }
}
