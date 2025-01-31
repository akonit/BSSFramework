﻿using Framework.DomainDriven.BLL;
using Framework.DomainDriven.Serialization;
using Framework.Persistent.Mapping;
using Framework.Security;

namespace SampleSystem.Domain.EnversBug1676;

[BLLViewRole]
[ViewDomainObject(typeof(SampleSystemSecurityOperation), nameof(SampleSystemSecurityOperation.Disabled))]
public class Location1676 : BaseDirectory
{
    private readonly ICollection<WorkingCalendar1676> calendar = new List<WorkingCalendar1676>();

    private Coefficient1676 coefficient;

    [Mapping(IsOneToOne = true)]
    [CustomSerialization(CustomSerializationMode.Ignore)]
    public virtual Coefficient1676 Coefficient
    {
        get => this.coefficient;
        protected internal set => this.coefficient = value;
    }

    public virtual IEnumerable<WorkingCalendar1676> Calendar => this.calendar;
}
