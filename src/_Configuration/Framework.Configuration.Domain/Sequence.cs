﻿using Framework.DomainDriven.BLL;
using Framework.Persistent;
using Framework.Persistent.Mapping;
using Framework.Restriction;
using Framework.Security;
using Framework.Validation;

namespace Framework.Configuration.Domain;

/// <summary>
/// Уникальный номер элемента системы
/// </summary>
[UniqueGroup]
[BLLViewRole, BLLSaveRole, BLLRemoveRole]
[ViewDomainObject(typeof(ConfigurationSecurityOperation), nameof(ConfigurationSecurityOperation.SequenceView))]
[EditDomainObject(typeof(ConfigurationSecurityOperation), nameof(ConfigurationSecurityOperation.SequenceEdit))]
[NotAuditedClass]
public class Sequence : BaseDirectory, INumberObject<long>
{
    private long number;

    /// <summary>
    /// Значение элемента
    /// </summary>
    [Int64ValueValidator(Min = 0)]
    public virtual long Number
    {
        get { return this.number; }
        set { this.number = value; }
    }
}
