﻿using Framework.Core;

namespace Framework.DomainDriven.BLL;

public static class TypeExtensions
{
    public static Type GetEventOperationType(this Type domainType)
    {
        if (domainType == null) throw new ArgumentNullException(nameof(domainType));

        return domainType.GetCustomAttribute<BLLEventRoleAttribute>().Maybe(v => v.EventOperationType);
    }

    public static IEnumerable<Enum> GetEventOperations(this Type domainType, Type eventType = null)
    {
        if (domainType == null) throw new ArgumentNullException(nameof(domainType));

        var attr = domainType.GetCustomAttribute<BLLEventRoleAttribute>();

        var mode = attr.Maybe(v => v.Mode, eventType != null ? EventRoleMode.ALL : 0);

        var operationType = attr.Maybe(v => v.EventOperationType) ?? eventType;

        return operationType.Maybe(EnumHelper.GetValuesE)
                            .EmptyIfNull()
                            .Where(v => mode.HasFlag(v.GetMode()));
    }

    private static EventRoleMode GetMode(this Enum value)
    {
        if (value == null) throw new ArgumentNullException(nameof(value));

        switch (value.ToString())
        {
            case "Save":
                return EventRoleMode.Save;

            case "Remove":
                return EventRoleMode.Remove;

            default:
                return EventRoleMode.Other;
        }
    }
}
