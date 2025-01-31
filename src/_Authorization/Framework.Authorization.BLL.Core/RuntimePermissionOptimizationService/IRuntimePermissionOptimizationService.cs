﻿namespace Framework.Authorization.BLL;

public interface IRuntimePermissionOptimizationService
{
    IEnumerable<Dictionary<Type, List<Guid>>> Optimize(IEnumerable<Dictionary<Type, List<Guid>>> permissions);
}
