﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Configurator.Client.Context.AuthService
{
    
    
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AuthService.AuthSLJsonController")]
    public partial interface AuthSLJsonController
    {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/ChangeDelegatePermissions", ReplyAction="http://tempuri.org/AuthSLJsonController/ChangeDelegatePermissionsResponse")]
        System.IAsyncResult BeginChangeDelegatePermissions(Framework.Authorization.Generated.DTO.ChangePermissionDelegatesModelStrictDTO changePermissionDelegatesModelStrictDTO, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/CreateBusinessRole", ReplyAction="http://tempuri.org/AuthSLJsonController/CreateBusinessRoleResponse")]
        System.IAsyncResult BeginCreateBusinessRole(Framework.Authorization.Generated.DTO.BusinessRoleCreateModelStrictDTO businessRoleCreateModel, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/CreatePrincipal", ReplyAction="http://tempuri.org/AuthSLJsonController/CreatePrincipalResponse")]
        System.IAsyncResult BeginCreatePrincipal(Framework.Authorization.Generated.DTO.PrincipalCreateModelStrictDTO principalCreateModel, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/FinishRunAsUser", ReplyAction="http://tempuri.org/AuthSLJsonController/FinishRunAsUserResponse")]
        System.IAsyncResult BeginFinishRunAsUser(System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetCurrentPrincipal", ReplyAction="http://tempuri.org/AuthSLJsonController/GetCurrentPrincipalResponse")]
        System.IAsyncResult BeginGetCurrentPrincipal(System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetFullBusinessRolesByIdents", ReplyAction="http://tempuri.org/AuthSLJsonController/GetFullBusinessRolesByIdentsResponse")]
        System.IAsyncResult BeginGetFullBusinessRolesByIdents(System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.BusinessRoleIdentityDTO> businessRoleIdents, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetFullBusinessRolesByRootFilter", ReplyAction="http://tempuri.org/AuthSLJsonController/GetFullBusinessRolesByRootFilterResponse")]
        System.IAsyncResult BeginGetFullBusinessRolesByRootFilter(Framework.Authorization.Generated.DTO.BusinessRoleRootFilterModelStrictDTO filter, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetFullOperationsByIdents", ReplyAction="http://tempuri.org/AuthSLJsonController/GetFullOperationsByIdentsResponse")]
        System.IAsyncResult BeginGetFullOperationsByIdents(System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.OperationIdentityDTO> operationIdents, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetFullOperationsByRootFilter", ReplyAction="http://tempuri.org/AuthSLJsonController/GetFullOperationsByRootFilterResponse")]
        System.IAsyncResult BeginGetFullOperationsByRootFilter(Framework.Authorization.Generated.DTO.OperationRootFilterModelStrictDTO filter, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetFullPrincipalsByIdents", ReplyAction="http://tempuri.org/AuthSLJsonController/GetFullPrincipalsByIdentsResponse")]
        System.IAsyncResult BeginGetFullPrincipalsByIdents(System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.PrincipalIdentityDTO> principalIdents, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetFullPrincipalsByRootFilter", ReplyAction="http://tempuri.org/AuthSLJsonController/GetFullPrincipalsByRootFilterResponse")]
        System.IAsyncResult BeginGetFullPrincipalsByRootFilter(Framework.Authorization.Generated.DTO.PrincipalRootFilterModelStrictDTO filter, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetFullSecurityEntities", ReplyAction="http://tempuri.org/AuthSLJsonController/GetFullSecurityEntitiesResponse")]
        System.IAsyncResult BeginGetFullSecurityEntities(Framework.Authorization.Generated.DTO.EntityTypeIdentityDTO entityTypeIdentity, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetFullSecurityEntitiesByIdents", ReplyAction="http://tempuri.org/AuthSLJsonController/GetFullSecurityEntitiesByIdentsResponse")]
        System.IAsyncResult BeginGetFullSecurityEntitiesByIdents(Framework.Authorization.Generated.DTO.GetFullSecurityEntitiesByIdentsRequest request, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetRichBusinessRole", ReplyAction="http://tempuri.org/AuthSLJsonController/GetRichBusinessRoleResponse")]
        System.IAsyncResult BeginGetRichBusinessRole(Framework.Authorization.Generated.DTO.BusinessRoleIdentityDTO businessRoleIdentity, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetRichOperation", ReplyAction="http://tempuri.org/AuthSLJsonController/GetRichOperationResponse")]
        System.IAsyncResult BeginGetRichOperation(Framework.Authorization.Generated.DTO.OperationIdentityDTO operationIdentity, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetRichPermission", ReplyAction="http://tempuri.org/AuthSLJsonController/GetRichPermissionResponse")]
        System.IAsyncResult BeginGetRichPermission(Framework.Authorization.Generated.DTO.PermissionIdentityDTO permissionIdentity, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetRichPermissionsByDirectFilter", ReplyAction="http://tempuri.org/AuthSLJsonController/GetRichPermissionsByDirectFilterResponse")]
        System.IAsyncResult BeginGetRichPermissionsByDirectFilter(Framework.Authorization.Generated.DTO.PermissionDirectFilterModelStrictDTO filter, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetRichPrincipal", ReplyAction="http://tempuri.org/AuthSLJsonController/GetRichPrincipalResponse")]
        System.IAsyncResult BeginGetRichPrincipal(Framework.Authorization.Generated.DTO.PrincipalIdentityDTO principalIdentity, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetSecurityOperations", ReplyAction="http://tempuri.org/AuthSLJsonController/GetSecurityOperationsResponse")]
        System.IAsyncResult BeginGetSecurityOperations(System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetSimpleBusinessRoles", ReplyAction="http://tempuri.org/AuthSLJsonController/GetSimpleBusinessRolesResponse")]
        System.IAsyncResult BeginGetSimpleBusinessRoles(System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetSimpleBusinessRolesByRootFilter", ReplyAction="http://tempuri.org/AuthSLJsonController/GetSimpleBusinessRolesByRootFilterRespons" +
            "e")]
        System.IAsyncResult BeginGetSimpleBusinessRolesByRootFilter(Framework.Authorization.Generated.DTO.BusinessRoleRootFilterModelStrictDTO filter, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetSimpleEntityTypeByName", ReplyAction="http://tempuri.org/AuthSLJsonController/GetSimpleEntityTypeByNameResponse")]
        System.IAsyncResult BeginGetSimpleEntityTypeByName(string entityTypeName, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetSimpleEntityTypes", ReplyAction="http://tempuri.org/AuthSLJsonController/GetSimpleEntityTypesResponse")]
        System.IAsyncResult BeginGetSimpleEntityTypes(System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetSimpleEntityTypesByRootFilter", ReplyAction="http://tempuri.org/AuthSLJsonController/GetSimpleEntityTypesByRootFilterResponse")]
        System.IAsyncResult BeginGetSimpleEntityTypesByRootFilter(Framework.Authorization.Generated.DTO.EntityTypeRootFilterModelStrictDTO filter, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetSimpleOperations", ReplyAction="http://tempuri.org/AuthSLJsonController/GetSimpleOperationsResponse")]
        System.IAsyncResult BeginGetSimpleOperations(System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetSimpleOperationsByRootFilter", ReplyAction="http://tempuri.org/AuthSLJsonController/GetSimpleOperationsByRootFilterResponse")]
        System.IAsyncResult BeginGetSimpleOperationsByRootFilter(Framework.Authorization.Generated.DTO.OperationRootFilterModelStrictDTO filter, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetSimplePrincipalByName", ReplyAction="http://tempuri.org/AuthSLJsonController/GetSimplePrincipalByNameResponse")]
        System.IAsyncResult BeginGetSimplePrincipalByName(string principalName, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetSimplePrincipals", ReplyAction="http://tempuri.org/AuthSLJsonController/GetSimplePrincipalsResponse")]
        System.IAsyncResult BeginGetSimplePrincipals(System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetSimplePrincipalsByRootFilter", ReplyAction="http://tempuri.org/AuthSLJsonController/GetSimplePrincipalsByRootFilterResponse")]
        System.IAsyncResult BeginGetSimplePrincipalsByRootFilter(Framework.Authorization.Generated.DTO.PrincipalRootFilterModelStrictDTO filter, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetVisualBusinessRoles", ReplyAction="http://tempuri.org/AuthSLJsonController/GetVisualBusinessRolesResponse")]
        System.IAsyncResult BeginGetVisualBusinessRoles(System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetVisualBusinessRolesByPermission", ReplyAction="http://tempuri.org/AuthSLJsonController/GetVisualBusinessRolesByPermissionRespons" +
            "e")]
        System.IAsyncResult BeginGetVisualBusinessRolesByPermission(Framework.Authorization.Generated.DTO.PermissionIdentityDTO permission, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/GetVisualPrincipalsWithoutSecurity", ReplyAction="http://tempuri.org/AuthSLJsonController/GetVisualPrincipalsWithoutSecurityRespons" +
            "e")]
        System.IAsyncResult BeginGetVisualPrincipalsWithoutSecurity(System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/RemoveBusinessRole", ReplyAction="http://tempuri.org/AuthSLJsonController/RemoveBusinessRoleResponse")]
        System.IAsyncResult BeginRemoveBusinessRole(Framework.Authorization.Generated.DTO.BusinessRoleIdentityDTO businessRoleIdent, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/RemovePrincipal", ReplyAction="http://tempuri.org/AuthSLJsonController/RemovePrincipalResponse")]
        System.IAsyncResult BeginRemovePrincipal(Framework.Authorization.Generated.DTO.PrincipalIdentityDTO principalIdent, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/RunAsUser", ReplyAction="http://tempuri.org/AuthSLJsonController/RunAsUserResponse")]
        System.IAsyncResult BeginRunAsUser(Framework.Authorization.Generated.DTO.PrincipalIdentityDTO principal, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/SaveBusinessRole", ReplyAction="http://tempuri.org/AuthSLJsonController/SaveBusinessRoleResponse")]
        System.IAsyncResult BeginSaveBusinessRole(Framework.Authorization.Generated.DTO.BusinessRoleStrictDTO businessRoleStrict, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/SaveOperation", ReplyAction="http://tempuri.org/AuthSLJsonController/SaveOperationResponse")]
        System.IAsyncResult BeginSaveOperation(Framework.Authorization.Generated.DTO.OperationStrictDTO operationStrict, System.AsyncCallback callback, object asyncState);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/AuthSLJsonController/SavePrincipal", ReplyAction="http://tempuri.org/AuthSLJsonController/SavePrincipalResponse")]
        System.IAsyncResult BeginSavePrincipal(Framework.Authorization.Generated.DTO.PrincipalStrictDTO principalStrict, System.AsyncCallback callback, object asyncState);
        
        void EndChangeDelegatePermissions(System.IAsyncResult result);
        
        Framework.Authorization.Generated.DTO.BusinessRoleRichDTO EndCreateBusinessRole(System.IAsyncResult result);
        
        Framework.Authorization.Generated.DTO.PrincipalRichDTO EndCreatePrincipal(System.IAsyncResult result);
        
        void EndFinishRunAsUser(System.IAsyncResult result);
        
        Framework.Authorization.Generated.DTO.PrincipalFullDTO EndGetCurrentPrincipal(System.IAsyncResult result);
        
        System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.BusinessRoleFullDTO> EndGetFullBusinessRolesByIdents(System.IAsyncResult result);
        
        System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.BusinessRoleFullDTO> EndGetFullBusinessRolesByRootFilter(System.IAsyncResult result);
        
        System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.OperationFullDTO> EndGetFullOperationsByIdents(System.IAsyncResult result);
        
        System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.OperationFullDTO> EndGetFullOperationsByRootFilter(System.IAsyncResult result);
        
        System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.PrincipalFullDTO> EndGetFullPrincipalsByIdents(System.IAsyncResult result);
        
        System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.PrincipalFullDTO> EndGetFullPrincipalsByRootFilter(System.IAsyncResult result);
        
        System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.SecurityEntityFullDTO> EndGetFullSecurityEntities(System.IAsyncResult result);
        
        System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.SecurityEntityFullDTO> EndGetFullSecurityEntitiesByIdents(System.IAsyncResult result);
        
        Framework.Authorization.Generated.DTO.BusinessRoleRichDTO EndGetRichBusinessRole(System.IAsyncResult result);
        
        Framework.Authorization.Generated.DTO.OperationRichDTO EndGetRichOperation(System.IAsyncResult result);
        
        Framework.Authorization.Generated.DTO.PermissionRichDTO EndGetRichPermission(System.IAsyncResult result);
        
        System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.PermissionRichDTO> EndGetRichPermissionsByDirectFilter(System.IAsyncResult result);
        
        Framework.Authorization.Generated.DTO.PrincipalRichDTO EndGetRichPrincipal(System.IAsyncResult result);
        
        System.Collections.ObjectModel.ObservableCollection<string> EndGetSecurityOperations(System.IAsyncResult result);
        
        System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.BusinessRoleSimpleDTO> EndGetSimpleBusinessRoles(System.IAsyncResult result);
        
        System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.BusinessRoleSimpleDTO> EndGetSimpleBusinessRolesByRootFilter(System.IAsyncResult result);
        
        Framework.Authorization.Generated.DTO.EntityTypeSimpleDTO EndGetSimpleEntityTypeByName(System.IAsyncResult result);
        
        System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.EntityTypeSimpleDTO> EndGetSimpleEntityTypes(System.IAsyncResult result);
        
        System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.EntityTypeSimpleDTO> EndGetSimpleEntityTypesByRootFilter(System.IAsyncResult result);
        
        System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.OperationSimpleDTO> EndGetSimpleOperations(System.IAsyncResult result);
        
        System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.OperationSimpleDTO> EndGetSimpleOperationsByRootFilter(System.IAsyncResult result);
        
        Framework.Authorization.Generated.DTO.PrincipalSimpleDTO EndGetSimplePrincipalByName(System.IAsyncResult result);
        
        System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.PrincipalSimpleDTO> EndGetSimplePrincipals(System.IAsyncResult result);
        
        System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.PrincipalSimpleDTO> EndGetSimplePrincipalsByRootFilter(System.IAsyncResult result);
        
        System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.BusinessRoleVisualDTO> EndGetVisualBusinessRoles(System.IAsyncResult result);
        
        System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.BusinessRoleVisualDTO> EndGetVisualBusinessRolesByPermission(System.IAsyncResult result);
        
        System.Collections.ObjectModel.ObservableCollection<Framework.Authorization.Generated.DTO.PrincipalVisualDTO> EndGetVisualPrincipalsWithoutSecurity(System.IAsyncResult result);
        
        void EndRemoveBusinessRole(System.IAsyncResult result);
        
        void EndRemovePrincipal(System.IAsyncResult result);
        
        void EndRunAsUser(System.IAsyncResult result);
        
        Framework.Authorization.Generated.DTO.BusinessRoleIdentityDTO EndSaveBusinessRole(System.IAsyncResult result);
        
        Framework.Authorization.Generated.DTO.OperationIdentityDTO EndSaveOperation(System.IAsyncResult result);
        
        Framework.Authorization.Generated.DTO.PrincipalIdentityDTO EndSavePrincipal(System.IAsyncResult result);
    }
}
