﻿namespace SampleSystem.WebApiCore.Controllers.Main
{
    using SampleSystem.Generated.DTO;
    
    
    [Microsoft.AspNetCore.Mvc.ApiControllerAttribute()]
    [Microsoft.AspNetCore.Mvc.ApiVersionAttribute("1.0")]
    [Microsoft.AspNetCore.Mvc.RouteAttribute("api/v{version:apiVersion}/[controller]")]
    public partial class TestSecuritySubObjItemController : Framework.DomainDriven.WebApiNetCore.ApiControllerBase<SampleSystem.BLL.ISampleSystemBLLContext, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<SampleSystem.BLL.ISampleSystemBLLContext, SampleSystem.Generated.DTO.ISampleSystemDTOMappingService>>
    {
        
        /// <summary>
        /// Get TestSecuritySubObjItem (FullDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullTestSecuritySubObjItem")]
        public virtual SampleSystem.Generated.DTO.TestSecuritySubObjItemFullDTO GetFullTestSecuritySubObjItem([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] SampleSystem.Generated.DTO.TestSecuritySubObjItemIdentityDTO testSecuritySubObjItemIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullTestSecuritySubObjItemInternal(testSecuritySubObjItemIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get TestSecuritySubObjItem (FullDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullTestSecuritySubObjItemByName")]
        public virtual SampleSystem.Generated.DTO.TestSecuritySubObjItemFullDTO GetFullTestSecuritySubObjItemByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string testSecuritySubObjItemName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullTestSecuritySubObjItemByNameInternal(testSecuritySubObjItemName, evaluateData));
        }
        
        protected virtual SampleSystem.Generated.DTO.TestSecuritySubObjItemFullDTO GetFullTestSecuritySubObjItemByNameInternal(string testSecuritySubObjItemName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<SampleSystem.BLL.ISampleSystemBLLContext, SampleSystem.Generated.DTO.ISampleSystemDTOMappingService> evaluateData)
        {
            SampleSystem.BLL.ITestSecuritySubObjItemBLL bll = evaluateData.Context.Logics.TestSecuritySubObjItemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            SampleSystem.Domain.TestSecuritySubObjItem domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, testSecuritySubObjItemName, true, evaluateData.Context.FetchService.GetContainer<SampleSystem.Domain.TestSecuritySubObjItem>(Framework.Transfering.ViewDTOType.FullDTO));
            return SampleSystem.Generated.DTO.LambdaHelper.ToFullDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual SampleSystem.Generated.DTO.TestSecuritySubObjItemFullDTO GetFullTestSecuritySubObjItemInternal(SampleSystem.Generated.DTO.TestSecuritySubObjItemIdentityDTO testSecuritySubObjItemIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<SampleSystem.BLL.ISampleSystemBLLContext, SampleSystem.Generated.DTO.ISampleSystemDTOMappingService> evaluateData)
        {
            SampleSystem.BLL.ITestSecuritySubObjItemBLL bll = evaluateData.Context.Logics.TestSecuritySubObjItemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            SampleSystem.Domain.TestSecuritySubObjItem domainObject = bll.GetById(testSecuritySubObjItemIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<SampleSystem.Domain.TestSecuritySubObjItem>(Framework.Transfering.ViewDTOType.FullDTO));
            return SampleSystem.Generated.DTO.LambdaHelper.ToFullDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get full list of TestSecuritySubObjItems (FullDTO)
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullTestSecuritySubObjItems")]
        public virtual System.Collections.Generic.IEnumerable<SampleSystem.Generated.DTO.TestSecuritySubObjItemFullDTO> GetFullTestSecuritySubObjItems()
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullTestSecuritySubObjItemsInternal(evaluateData));
        }
        
        /// <summary>
        /// Get TestSecuritySubObjItems (FullDTO) by idents
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullTestSecuritySubObjItemsByIdents")]
        public virtual System.Collections.Generic.IEnumerable<SampleSystem.Generated.DTO.TestSecuritySubObjItemFullDTO> GetFullTestSecuritySubObjItemsByIdents([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] SampleSystem.Generated.DTO.TestSecuritySubObjItemIdentityDTO[] testSecuritySubObjItemIdents)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullTestSecuritySubObjItemsByIdentsInternal(testSecuritySubObjItemIdents, evaluateData));
        }
        
        protected virtual System.Collections.Generic.IEnumerable<SampleSystem.Generated.DTO.TestSecuritySubObjItemFullDTO> GetFullTestSecuritySubObjItemsByIdentsInternal(SampleSystem.Generated.DTO.TestSecuritySubObjItemIdentityDTO[] testSecuritySubObjItemIdents, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<SampleSystem.BLL.ISampleSystemBLLContext, SampleSystem.Generated.DTO.ISampleSystemDTOMappingService> evaluateData)
        {
            SampleSystem.BLL.ITestSecuritySubObjItemBLL bll = evaluateData.Context.Logics.TestSecuritySubObjItemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return SampleSystem.Generated.DTO.LambdaHelper.ToFullDTOList(bll.GetListByIdents(testSecuritySubObjItemIdents, evaluateData.Context.FetchService.GetContainer<SampleSystem.Domain.TestSecuritySubObjItem>(Framework.Transfering.ViewDTOType.FullDTO)), evaluateData.MappingService);
        }
        
        protected virtual System.Collections.Generic.IEnumerable<SampleSystem.Generated.DTO.TestSecuritySubObjItemFullDTO> GetFullTestSecuritySubObjItemsInternal(Framework.DomainDriven.ServiceModel.Service.EvaluatedData<SampleSystem.BLL.ISampleSystemBLLContext, SampleSystem.Generated.DTO.ISampleSystemDTOMappingService> evaluateData)
        {
            SampleSystem.BLL.ITestSecuritySubObjItemBLL bll = evaluateData.Context.Logics.TestSecuritySubObjItemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return SampleSystem.Generated.DTO.LambdaHelper.ToFullDTOList(bll.GetFullList(evaluateData.Context.FetchService.GetContainer<SampleSystem.Domain.TestSecuritySubObjItem>(Framework.Transfering.ViewDTOType.FullDTO)), evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get TestSecuritySubObjItem (RichDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetRichTestSecuritySubObjItem")]
        public virtual SampleSystem.Generated.DTO.TestSecuritySubObjItemRichDTO GetRichTestSecuritySubObjItem([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] SampleSystem.Generated.DTO.TestSecuritySubObjItemIdentityDTO testSecuritySubObjItemIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetRichTestSecuritySubObjItemInternal(testSecuritySubObjItemIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get TestSecuritySubObjItem (RichDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetRichTestSecuritySubObjItemByName")]
        public virtual SampleSystem.Generated.DTO.TestSecuritySubObjItemRichDTO GetRichTestSecuritySubObjItemByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string testSecuritySubObjItemName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetRichTestSecuritySubObjItemByNameInternal(testSecuritySubObjItemName, evaluateData));
        }
        
        protected virtual SampleSystem.Generated.DTO.TestSecuritySubObjItemRichDTO GetRichTestSecuritySubObjItemByNameInternal(string testSecuritySubObjItemName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<SampleSystem.BLL.ISampleSystemBLLContext, SampleSystem.Generated.DTO.ISampleSystemDTOMappingService> evaluateData)
        {
            SampleSystem.BLL.ITestSecuritySubObjItemBLL bll = evaluateData.Context.Logics.TestSecuritySubObjItemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            SampleSystem.Domain.TestSecuritySubObjItem domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, testSecuritySubObjItemName, true, evaluateData.Context.FetchService.GetContainer<SampleSystem.Domain.TestSecuritySubObjItem>(Framework.Transfering.ViewDTOType.FullDTO));
            return SampleSystem.Generated.DTO.LambdaHelper.ToRichDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual SampleSystem.Generated.DTO.TestSecuritySubObjItemRichDTO GetRichTestSecuritySubObjItemInternal(SampleSystem.Generated.DTO.TestSecuritySubObjItemIdentityDTO testSecuritySubObjItemIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<SampleSystem.BLL.ISampleSystemBLLContext, SampleSystem.Generated.DTO.ISampleSystemDTOMappingService> evaluateData)
        {
            SampleSystem.BLL.ITestSecuritySubObjItemBLL bll = evaluateData.Context.Logics.TestSecuritySubObjItemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            SampleSystem.Domain.TestSecuritySubObjItem domainObject = bll.GetById(testSecuritySubObjItemIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<SampleSystem.Domain.TestSecuritySubObjItem>(Framework.Transfering.ViewDTOType.FullDTO));
            return SampleSystem.Generated.DTO.LambdaHelper.ToRichDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get TestSecuritySubObjItem (SimpleDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleTestSecuritySubObjItem")]
        public virtual SampleSystem.Generated.DTO.TestSecuritySubObjItemSimpleDTO GetSimpleTestSecuritySubObjItem([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] SampleSystem.Generated.DTO.TestSecuritySubObjItemIdentityDTO testSecuritySubObjItemIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleTestSecuritySubObjItemInternal(testSecuritySubObjItemIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get TestSecuritySubObjItem (SimpleDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleTestSecuritySubObjItemByName")]
        public virtual SampleSystem.Generated.DTO.TestSecuritySubObjItemSimpleDTO GetSimpleTestSecuritySubObjItemByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string testSecuritySubObjItemName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleTestSecuritySubObjItemByNameInternal(testSecuritySubObjItemName, evaluateData));
        }
        
        protected virtual SampleSystem.Generated.DTO.TestSecuritySubObjItemSimpleDTO GetSimpleTestSecuritySubObjItemByNameInternal(string testSecuritySubObjItemName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<SampleSystem.BLL.ISampleSystemBLLContext, SampleSystem.Generated.DTO.ISampleSystemDTOMappingService> evaluateData)
        {
            SampleSystem.BLL.ITestSecuritySubObjItemBLL bll = evaluateData.Context.Logics.TestSecuritySubObjItemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            SampleSystem.Domain.TestSecuritySubObjItem domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, testSecuritySubObjItemName, true, evaluateData.Context.FetchService.GetContainer<SampleSystem.Domain.TestSecuritySubObjItem>(Framework.Transfering.ViewDTOType.SimpleDTO));
            return SampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual SampleSystem.Generated.DTO.TestSecuritySubObjItemSimpleDTO GetSimpleTestSecuritySubObjItemInternal(SampleSystem.Generated.DTO.TestSecuritySubObjItemIdentityDTO testSecuritySubObjItemIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<SampleSystem.BLL.ISampleSystemBLLContext, SampleSystem.Generated.DTO.ISampleSystemDTOMappingService> evaluateData)
        {
            SampleSystem.BLL.ITestSecuritySubObjItemBLL bll = evaluateData.Context.Logics.TestSecuritySubObjItemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            SampleSystem.Domain.TestSecuritySubObjItem domainObject = bll.GetById(testSecuritySubObjItemIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<SampleSystem.Domain.TestSecuritySubObjItem>(Framework.Transfering.ViewDTOType.SimpleDTO));
            return SampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get full list of TestSecuritySubObjItems (SimpleDTO)
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleTestSecuritySubObjItems")]
        public virtual System.Collections.Generic.IEnumerable<SampleSystem.Generated.DTO.TestSecuritySubObjItemSimpleDTO> GetSimpleTestSecuritySubObjItems()
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleTestSecuritySubObjItemsInternal(evaluateData));
        }
        
        /// <summary>
        /// Get TestSecuritySubObjItems (SimpleDTO) by idents
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleTestSecuritySubObjItemsByIdents")]
        public virtual System.Collections.Generic.IEnumerable<SampleSystem.Generated.DTO.TestSecuritySubObjItemSimpleDTO> GetSimpleTestSecuritySubObjItemsByIdents([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] SampleSystem.Generated.DTO.TestSecuritySubObjItemIdentityDTO[] testSecuritySubObjItemIdents)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleTestSecuritySubObjItemsByIdentsInternal(testSecuritySubObjItemIdents, evaluateData));
        }
        
        protected virtual System.Collections.Generic.IEnumerable<SampleSystem.Generated.DTO.TestSecuritySubObjItemSimpleDTO> GetSimpleTestSecuritySubObjItemsByIdentsInternal(SampleSystem.Generated.DTO.TestSecuritySubObjItemIdentityDTO[] testSecuritySubObjItemIdents, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<SampleSystem.BLL.ISampleSystemBLLContext, SampleSystem.Generated.DTO.ISampleSystemDTOMappingService> evaluateData)
        {
            SampleSystem.BLL.ITestSecuritySubObjItemBLL bll = evaluateData.Context.Logics.TestSecuritySubObjItemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return SampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTOList(bll.GetListByIdents(testSecuritySubObjItemIdents, evaluateData.Context.FetchService.GetContainer<SampleSystem.Domain.TestSecuritySubObjItem>(Framework.Transfering.ViewDTOType.SimpleDTO)), evaluateData.MappingService);
        }
        
        protected virtual System.Collections.Generic.IEnumerable<SampleSystem.Generated.DTO.TestSecuritySubObjItemSimpleDTO> GetSimpleTestSecuritySubObjItemsInternal(Framework.DomainDriven.ServiceModel.Service.EvaluatedData<SampleSystem.BLL.ISampleSystemBLLContext, SampleSystem.Generated.DTO.ISampleSystemDTOMappingService> evaluateData)
        {
            SampleSystem.BLL.ITestSecuritySubObjItemBLL bll = evaluateData.Context.Logics.TestSecuritySubObjItemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return SampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTOList(bll.GetFullList(evaluateData.Context.FetchService.GetContainer<SampleSystem.Domain.TestSecuritySubObjItem>(Framework.Transfering.ViewDTOType.SimpleDTO)), evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get TestSecuritySubObjItem (VisualDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualTestSecuritySubObjItem")]
        public virtual SampleSystem.Generated.DTO.TestSecuritySubObjItemVisualDTO GetVisualTestSecuritySubObjItem([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] SampleSystem.Generated.DTO.TestSecuritySubObjItemIdentityDTO testSecuritySubObjItemIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualTestSecuritySubObjItemInternal(testSecuritySubObjItemIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get TestSecuritySubObjItem (VisualDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualTestSecuritySubObjItemByName")]
        public virtual SampleSystem.Generated.DTO.TestSecuritySubObjItemVisualDTO GetVisualTestSecuritySubObjItemByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string testSecuritySubObjItemName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualTestSecuritySubObjItemByNameInternal(testSecuritySubObjItemName, evaluateData));
        }
        
        protected virtual SampleSystem.Generated.DTO.TestSecuritySubObjItemVisualDTO GetVisualTestSecuritySubObjItemByNameInternal(string testSecuritySubObjItemName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<SampleSystem.BLL.ISampleSystemBLLContext, SampleSystem.Generated.DTO.ISampleSystemDTOMappingService> evaluateData)
        {
            SampleSystem.BLL.ITestSecuritySubObjItemBLL bll = evaluateData.Context.Logics.TestSecuritySubObjItemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            SampleSystem.Domain.TestSecuritySubObjItem domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, testSecuritySubObjItemName, true, evaluateData.Context.FetchService.GetContainer<SampleSystem.Domain.TestSecuritySubObjItem>(Framework.Transfering.ViewDTOType.VisualDTO));
            return SampleSystem.Generated.DTO.LambdaHelper.ToVisualDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual SampleSystem.Generated.DTO.TestSecuritySubObjItemVisualDTO GetVisualTestSecuritySubObjItemInternal(SampleSystem.Generated.DTO.TestSecuritySubObjItemIdentityDTO testSecuritySubObjItemIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<SampleSystem.BLL.ISampleSystemBLLContext, SampleSystem.Generated.DTO.ISampleSystemDTOMappingService> evaluateData)
        {
            SampleSystem.BLL.ITestSecuritySubObjItemBLL bll = evaluateData.Context.Logics.TestSecuritySubObjItemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            SampleSystem.Domain.TestSecuritySubObjItem domainObject = bll.GetById(testSecuritySubObjItemIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<SampleSystem.Domain.TestSecuritySubObjItem>(Framework.Transfering.ViewDTOType.VisualDTO));
            return SampleSystem.Generated.DTO.LambdaHelper.ToVisualDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get full list of TestSecuritySubObjItems (VisualDTO)
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualTestSecuritySubObjItems")]
        public virtual System.Collections.Generic.IEnumerable<SampleSystem.Generated.DTO.TestSecuritySubObjItemVisualDTO> GetVisualTestSecuritySubObjItems()
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualTestSecuritySubObjItemsInternal(evaluateData));
        }
        
        /// <summary>
        /// Get TestSecuritySubObjItems (VisualDTO) by idents
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualTestSecuritySubObjItemsByIdents")]
        public virtual System.Collections.Generic.IEnumerable<SampleSystem.Generated.DTO.TestSecuritySubObjItemVisualDTO> GetVisualTestSecuritySubObjItemsByIdents([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] SampleSystem.Generated.DTO.TestSecuritySubObjItemIdentityDTO[] testSecuritySubObjItemIdents)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualTestSecuritySubObjItemsByIdentsInternal(testSecuritySubObjItemIdents, evaluateData));
        }
        
        protected virtual System.Collections.Generic.IEnumerable<SampleSystem.Generated.DTO.TestSecuritySubObjItemVisualDTO> GetVisualTestSecuritySubObjItemsByIdentsInternal(SampleSystem.Generated.DTO.TestSecuritySubObjItemIdentityDTO[] testSecuritySubObjItemIdents, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<SampleSystem.BLL.ISampleSystemBLLContext, SampleSystem.Generated.DTO.ISampleSystemDTOMappingService> evaluateData)
        {
            SampleSystem.BLL.ITestSecuritySubObjItemBLL bll = evaluateData.Context.Logics.TestSecuritySubObjItemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return SampleSystem.Generated.DTO.LambdaHelper.ToVisualDTOList(bll.GetListByIdents(testSecuritySubObjItemIdents, evaluateData.Context.FetchService.GetContainer<SampleSystem.Domain.TestSecuritySubObjItem>(Framework.Transfering.ViewDTOType.VisualDTO)), evaluateData.MappingService);
        }
        
        protected virtual System.Collections.Generic.IEnumerable<SampleSystem.Generated.DTO.TestSecuritySubObjItemVisualDTO> GetVisualTestSecuritySubObjItemsInternal(Framework.DomainDriven.ServiceModel.Service.EvaluatedData<SampleSystem.BLL.ISampleSystemBLLContext, SampleSystem.Generated.DTO.ISampleSystemDTOMappingService> evaluateData)
        {
            SampleSystem.BLL.ITestSecuritySubObjItemBLL bll = evaluateData.Context.Logics.TestSecuritySubObjItemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return SampleSystem.Generated.DTO.LambdaHelper.ToVisualDTOList(bll.GetFullList(evaluateData.Context.FetchService.GetContainer<SampleSystem.Domain.TestSecuritySubObjItem>(Framework.Transfering.ViewDTOType.VisualDTO)), evaluateData.MappingService);
        }
    }
}
