﻿using Framework.Core;
using Framework.Persistent;

namespace Framework.SecuritySystem;

public class AccessDeniedExceptionService : IAccessDeniedExceptionService
{
    private readonly IDomainObjectIdentResolver domainObjectIdentResolver;

    public AccessDeniedExceptionService(IDomainObjectIdentResolver domainObjectIdentResolver)
    {
        this.domainObjectIdentResolver = domainObjectIdentResolver;
    }

    public Exception GetAccessDeniedException(AccessResult.AccessDeniedResult accessDeniedResult)
    {
        return new AccessDeniedException(this.GetAccessDeniedExceptionMessage(accessDeniedResult));
    }

    public string GetAccessDeniedExceptionMessage(AccessResult.AccessDeniedResult accessDeniedResult)
    {
        if (accessDeniedResult.CustomMessage != null)
        {
            return accessDeniedResult.CustomMessage;
        }
        else
        {
            var securityOperation = accessDeniedResult.SecurityOperation;

            if (accessDeniedResult.DomainObjectInfo == null)
            {
                if (securityOperation == null)
                {
                    return $"You are not authorized to perform operation";
                }
                else
                {
                    return $"You are not authorized to perform '{securityOperation}' operation";
                }
            }
            else
            {
                var info = accessDeniedResult.DomainObjectInfo.Value;

                return this.GetAccessDeniedExceptionMessage(info.DomainObject, info.DomainObjectType, securityOperation);
            }
        }
    }

    protected virtual string GetAccessDeniedExceptionMessage(object domainObject, Type domainObjectType, SecurityOperation securityOperation)
    {
        if (domainObject == null) throw new ArgumentNullException(nameof(domainObject));

        var elements = this.GetAccessDeniedExceptionMessageElements(domainObject, domainObjectType, securityOperation).ToDictionary();

        return elements.GetByFirst((first, other) =>
                                   {
                                       var messagePrefix = this.domainObjectIdentResolver.HasDefaultIdent(domainObject) ? "You have no permissions to create object"

                                                               : "You have no permissions to access object";

                                       var messageBody = $" with {this.PrintElement(first.Key, first.Value)}";

                                       var messagePostfix = other.Any() ? $" ({other.Join(", ", pair => this.PrintElement(pair.Key, pair.Value))})" : "";

                                       return messagePrefix + messageBody + messagePostfix;
                                   });
    }

    protected string PrintElement(string key, object value)
    {
        return $"{key} = '{value}'";
    }

    protected IEnumerable<KeyValuePair<string, object>> GetAccessDeniedExceptionMessageElements(object domainObject, Type domainObjectType, SecurityOperation securityOperation)
    {
        if (domainObject is IVisualIdentityObject visualIdentityObject)
        {
            var name = visualIdentityObject.Name;

            yield return new KeyValuePair<string, object>("name", name);
        }

        yield return new KeyValuePair<string, object>("type", domainObjectType);

        var ident = this.domainObjectIdentResolver.TryGetIdent(domainObject);

        if (ident != null)
        {
            yield return new KeyValuePair<string, object>("id", ident);
        }

        if (securityOperation != null)
        {
            yield return new KeyValuePair<string, object>("securityOperation", securityOperation.Name);
        }
    }
}
