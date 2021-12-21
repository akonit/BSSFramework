﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleSystem.Generated.DTO
{
    
    
    [Framework.DomainDriven.DTOFileTypeAttribute(typeof(SampleSystem.Domain.ManualProjections.TestManualEmployeeProjection), "ProjectionDTO", Framework.DomainDriven.Serialization.DTORole.Client)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="SampleSystem")]
    public partial class TestManualEmployeeProjectionDTO : SampleSystem.Generated.DTO.BasePersistentDTO, Framework.Persistent.IIdentityObjectContainer<SampleSystem.Generated.DTO.EmployeeIdentityDTO>
    {
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Login;
        
        public TestManualEmployeeProjectionDTO()
        {
        }
        
        public TestManualEmployeeProjectionDTO(SampleSystem.Generated.DTO.ISampleSystemDTOMappingService mappingService, SampleSystem.Domain.ManualProjections.TestManualEmployeeProjection domainObject) : 
                base(mappingService, domainObject)
        {
            mappingService.MapTestManualEmployeeProjection(domainObject, this);
        }
        
        public SampleSystem.Generated.DTO.EmployeeIdentityDTO Identity
        {
            get
            {
                return new SampleSystem.Generated.DTO.EmployeeIdentityDTO(this.Id);
            }
        }
    }
    
    [Framework.DomainDriven.DTOFileTypeAttribute(typeof(SampleSystem.Domain.Projections.BusinessUnitIdentity), "ProjectionDTO", Framework.DomainDriven.Serialization.DTORole.Client)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="SampleSystem")]
    public partial class BusinessUnitIdentityProjectionDTO : SampleSystem.Generated.DTO.BasePersistentDTO, Framework.Persistent.IIdentityObjectContainer<SampleSystem.Generated.DTO.BusinessUnitIdentityDTO>
    {
        
        public BusinessUnitIdentityProjectionDTO()
        {
        }
        
        public BusinessUnitIdentityProjectionDTO(SampleSystem.Generated.DTO.ISampleSystemDTOMappingService mappingService, SampleSystem.Domain.Projections.BusinessUnitIdentity domainObject) : 
                base(mappingService, domainObject)
        {
            mappingService.MapBusinessUnitIdentity(domainObject, this);
        }
        
        public SampleSystem.Generated.DTO.BusinessUnitIdentityDTO Identity
        {
            get
            {
                return new SampleSystem.Generated.DTO.BusinessUnitIdentityDTO(this.Id);
            }
        }
    }
    
    [Framework.DomainDriven.DTOFileTypeAttribute(typeof(SampleSystem.Domain.Projections.BusinessUnitProgramClass), "ProjectionDTO", Framework.DomainDriven.Serialization.DTORole.Client)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="SampleSystem")]
    public partial class BusinessUnitProgramClassProjectionDTO : SampleSystem.Generated.DTO.BasePersistentDTO, Framework.Persistent.IIdentityObjectContainer<SampleSystem.Generated.DTO.BusinessUnitIdentityDTO>
    {
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsNewBusiness;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VirtualName;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VirtualValue;
        
        public BusinessUnitProgramClassProjectionDTO()
        {
        }
        
        public BusinessUnitProgramClassProjectionDTO(SampleSystem.Generated.DTO.ISampleSystemDTOMappingService mappingService, SampleSystem.Domain.Projections.BusinessUnitProgramClass domainObject) : 
                base(mappingService, domainObject)
        {
            mappingService.MapBusinessUnitProgramClass(domainObject, this);
        }
        
        public SampleSystem.Generated.DTO.BusinessUnitIdentityDTO Identity
        {
            get
            {
                return new SampleSystem.Generated.DTO.BusinessUnitIdentityDTO(this.Id);
            }
        }
    }
    
    [Framework.DomainDriven.DTOFileTypeAttribute(typeof(SampleSystem.Domain.Projections.CustomCompanyLegalEntity), "ProjectionDTO", Framework.DomainDriven.Serialization.DTORole.Client)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="SampleSystem")]
    public partial class CustomCompanyLegalEntityProjectionDTO : SampleSystem.Generated.DTO.BasePersistentDTO, Framework.Persistent.IIdentityObjectContainer<SampleSystem.Generated.DTO.CompanyLegalEntityIdentityDTO>
    {
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AribaStatusDescription;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SampleSystem.Domain.AribaStatusType AribaStatusType;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SampleSystem.Generated.DTO.CustomTestObjForNestedProjectionDTO BaseObj;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Framework.Core.Maybe<string> Code;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SampleSystem.Generated.DTO.CustomTestObjForNestedProjectionDTO CurrentObj;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameEnglish;
        
        public CustomCompanyLegalEntityProjectionDTO()
        {
        }
        
        public CustomCompanyLegalEntityProjectionDTO(SampleSystem.Generated.DTO.ISampleSystemDTOMappingService mappingService, SampleSystem.Domain.Projections.CustomCompanyLegalEntity domainObject) : 
                base(mappingService, domainObject)
        {
            mappingService.MapCustomCompanyLegalEntity(domainObject, this);
        }
        
        public SampleSystem.Generated.DTO.CompanyLegalEntityIdentityDTO Identity
        {
            get
            {
                return new SampleSystem.Generated.DTO.CompanyLegalEntityIdentityDTO(this.Id);
            }
        }
    }
    
    [Framework.DomainDriven.DTOFileTypeAttribute(typeof(SampleSystem.Domain.Projections.CustomTestObjForNested), "ProjectionDTO", Framework.DomainDriven.Serialization.DTORole.Client)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="SampleSystem")]
    public partial class CustomTestObjForNestedProjectionDTO : SampleSystem.Generated.DTO.BasePersistentDTO, Framework.Persistent.IIdentityObjectContainer<SampleSystem.Generated.DTO.TestObjForNestedIdentityDTO>
    {
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime PeriodStartDateXXX;
        
        public CustomTestObjForNestedProjectionDTO()
        {
        }
        
        public CustomTestObjForNestedProjectionDTO(SampleSystem.Generated.DTO.ISampleSystemDTOMappingService mappingService, SampleSystem.Domain.Projections.CustomTestObjForNested domainObject) : 
                base(mappingService, domainObject)
        {
            mappingService.MapCustomTestObjForNested(domainObject, this);
        }
        
        public SampleSystem.Generated.DTO.TestObjForNestedIdentityDTO Identity
        {
            get
            {
                return new SampleSystem.Generated.DTO.TestObjForNestedIdentityDTO(this.Id);
            }
        }
    }
    
    [Framework.DomainDriven.DTOFileTypeAttribute(typeof(SampleSystem.Domain.Projections.HerBusinessUnit), "ProjectionDTO", Framework.DomainDriven.Serialization.DTORole.Client)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="SampleSystem")]
    public partial class HerBusinessUnitProjectionDTO : SampleSystem.Generated.DTO.BasePersistentDTO, Framework.Persistent.IIdentityObjectContainer<SampleSystem.Generated.DTO.BusinessUnitIdentityDTO>
    {
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SampleSystem.Generated.DTO.HerBusinessUnitProjectionDTO Parent;
        
        public HerBusinessUnitProjectionDTO()
        {
        }
        
        public HerBusinessUnitProjectionDTO(SampleSystem.Generated.DTO.ISampleSystemDTOMappingService mappingService, SampleSystem.Domain.Projections.HerBusinessUnit domainObject) : 
                base(mappingService, domainObject)
        {
            mappingService.MapHerBusinessUnit(domainObject, this);
        }
        
        public SampleSystem.Generated.DTO.BusinessUnitIdentityDTO Identity
        {
            get
            {
                return new SampleSystem.Generated.DTO.BusinessUnitIdentityDTO(this.Id);
            }
        }
    }
    
    [Framework.DomainDriven.DTOFileTypeAttribute(typeof(SampleSystem.Domain.Projections.MiniBusinessUnitEmployeeRole), "ProjectionDTO", Framework.DomainDriven.Serialization.DTORole.Client)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="SampleSystem")]
    public partial class MiniBusinessUnitEmployeeRoleProjectionDTO : SampleSystem.Generated.DTO.BasePersistentDTO, Framework.Persistent.IIdentityObjectContainer<SampleSystem.Generated.DTO.BusinessUnitEmployeeRoleIdentityDTO>
    {
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SampleSystem.Generated.DTO.VisualEmployeeProjectionDTO Employee;
        
        public MiniBusinessUnitEmployeeRoleProjectionDTO()
        {
        }
        
        public MiniBusinessUnitEmployeeRoleProjectionDTO(SampleSystem.Generated.DTO.ISampleSystemDTOMappingService mappingService, SampleSystem.Domain.Projections.MiniBusinessUnitEmployeeRole domainObject) : 
                base(mappingService, domainObject)
        {
            mappingService.MapMiniBusinessUnitEmployeeRole(domainObject, this);
        }
        
        public SampleSystem.Generated.DTO.BusinessUnitEmployeeRoleIdentityDTO Identity
        {
            get
            {
                return new SampleSystem.Generated.DTO.BusinessUnitEmployeeRoleIdentityDTO(this.Id);
            }
        }
    }
    
    [Framework.DomainDriven.DTOFileTypeAttribute(typeof(SampleSystem.Domain.Projections.TestBusinessUnit), "ProjectionDTO", Framework.DomainDriven.Serialization.DTORole.Client)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="SampleSystem")]
    public partial class TestBusinessUnitProjectionDTO : SampleSystem.Generated.DTO.BasePersistentDTO, Framework.Persistent.IIdentityObjectContainer<SampleSystem.Generated.DTO.BusinessUnitIdentityDTO>
    {
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[][] CalcMatrix;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SampleSystem.Generated.DTO.TestBusinessUnitTypeProjectionDTO CalcProjectionProp;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CalcProp;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Employees;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HerBusinessUnit_Full;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime? ParentPeriodStartDate;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime? PeriodEndDate;
        
        public TestBusinessUnitProjectionDTO()
        {
        }
        
        public TestBusinessUnitProjectionDTO(SampleSystem.Generated.DTO.ISampleSystemDTOMappingService mappingService, SampleSystem.Domain.Projections.TestBusinessUnit domainObject) : 
                base(mappingService, domainObject)
        {
            mappingService.MapTestBusinessUnit(domainObject, this);
        }
        
        public SampleSystem.Generated.DTO.BusinessUnitIdentityDTO Identity
        {
            get
            {
                return new SampleSystem.Generated.DTO.BusinessUnitIdentityDTO(this.Id);
            }
        }
    }
    
    [Framework.DomainDriven.DTOFileTypeAttribute(typeof(SampleSystem.Domain.Projections.TestBusinessUnitType), "ProjectionDTO", Framework.DomainDriven.Serialization.DTORole.Client)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="SampleSystem")]
    public partial class TestBusinessUnitTypeProjectionDTO : SampleSystem.Generated.DTO.BaseAbstractDTO
    {
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name;
        
        public TestBusinessUnitTypeProjectionDTO()
        {
        }
        
        public TestBusinessUnitTypeProjectionDTO(SampleSystem.Generated.DTO.ISampleSystemDTOMappingService mappingService, SampleSystem.Domain.Projections.TestBusinessUnitType domainObject) : 
                base(mappingService, domainObject)
        {
            mappingService.MapTestBusinessUnitType(domainObject, this);
        }
    }
    
    [Framework.DomainDriven.DTOFileTypeAttribute(typeof(SampleSystem.Domain.Projections.TestCustomContextSecurityObjProjection), "ProjectionDTO", Framework.DomainDriven.Serialization.DTORole.Client)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="SampleSystem")]
    public partial class TestCustomContextSecurityObjProjectionDTO : SampleSystem.Generated.DTO.BasePersistentDTO, Framework.Persistent.IIdentityObjectContainer<SampleSystem.Generated.DTO.TestCustomContextSecurityObjIdentityDTO>
    {
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name;
        
        public TestCustomContextSecurityObjProjectionDTO()
        {
        }
        
        public TestCustomContextSecurityObjProjectionDTO(SampleSystem.Generated.DTO.ISampleSystemDTOMappingService mappingService, SampleSystem.Domain.Projections.TestCustomContextSecurityObjProjection domainObject) : 
                base(mappingService, domainObject)
        {
            mappingService.MapTestCustomContextSecurityObjProjection(domainObject, this);
        }
        
        public SampleSystem.Generated.DTO.TestCustomContextSecurityObjIdentityDTO Identity
        {
            get
            {
                return new SampleSystem.Generated.DTO.TestCustomContextSecurityObjIdentityDTO(this.Id);
            }
        }
    }
    
    [Framework.DomainDriven.DTOFileTypeAttribute(typeof(SampleSystem.Domain.Projections.TestDepartment), "ProjectionDTO", Framework.DomainDriven.Serialization.DTORole.Client)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="SampleSystem")]
    public partial class TestDepartmentProjectionDTO : SampleSystem.Generated.DTO.BasePersistentDTO, Framework.Persistent.IIdentityObjectContainer<SampleSystem.Generated.DTO.HRDepartmentIdentityDTO>
    {
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SampleSystem.Generated.DTO.TestLocationProjectionDTO Location;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] LocationBinaryData;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name;
        
        public TestDepartmentProjectionDTO()
        {
        }
        
        public TestDepartmentProjectionDTO(SampleSystem.Generated.DTO.ISampleSystemDTOMappingService mappingService, SampleSystem.Domain.Projections.TestDepartment domainObject) : 
                base(mappingService, domainObject)
        {
            mappingService.MapTestDepartment(domainObject, this);
        }
        
        public SampleSystem.Generated.DTO.HRDepartmentIdentityDTO Identity
        {
            get
            {
                return new SampleSystem.Generated.DTO.HRDepartmentIdentityDTO(this.Id);
            }
        }
    }
    
    [Framework.DomainDriven.DTOFileTypeAttribute(typeof(SampleSystem.Domain.Projections.TestEmployee), "ProjectionDTO", Framework.DomainDriven.Serialization.DTORole.Client)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="SampleSystem")]
    public partial class TestEmployeeProjectionDTO : SampleSystem.Generated.DTO.BasePersistentDTO, Framework.Persistent.IIdentityObjectContainer<SampleSystem.Generated.DTO.EmployeeIdentityDTO>
    {
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime? BuEndDate;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SampleSystem.Generated.DTO.BusinessUnitIdentityProjectionDTO CoreBusinessUnit;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CoreBusinessUnitName;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<SampleSystem.Generated.DTO.VisualProjectProjectionDTO> CoreBusinessUnitProjects;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Framework.Core.Maybe<string> Login;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameEngFirstName;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Framework.Core.Maybe<string> PositionName;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PpmNameNativeMiddleName;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid? RoleId;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RoleName;
        
        public TestEmployeeProjectionDTO()
        {
        }
        
        public TestEmployeeProjectionDTO(SampleSystem.Generated.DTO.ISampleSystemDTOMappingService mappingService, SampleSystem.Domain.Projections.TestEmployee domainObject) : 
                base(mappingService, domainObject)
        {
            mappingService.MapTestEmployee(domainObject, this);
        }
        
        public SampleSystem.Generated.DTO.EmployeeIdentityDTO Identity
        {
            get
            {
                return new SampleSystem.Generated.DTO.EmployeeIdentityDTO(this.Id);
            }
        }
    }
    
    [Framework.DomainDriven.DTOFileTypeAttribute(typeof(SampleSystem.Domain.Projections.TestIMRequest), "ProjectionDTO", Framework.DomainDriven.Serialization.DTORole.Client)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="SampleSystem")]
    public partial class TestIMRequestProjectionDTO : SampleSystem.Generated.DTO.BasePersistentDTO, Framework.Persistent.IIdentityObjectContainer<SampleSystem.Generated.DTO.IMRequestIdentityDTO>
    {
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SampleSystem.Generated.DTO.TestIMRequestDetailProjectionDTO OneToOneDetail;
        
        public TestIMRequestProjectionDTO()
        {
        }
        
        public TestIMRequestProjectionDTO(SampleSystem.Generated.DTO.ISampleSystemDTOMappingService mappingService, SampleSystem.Domain.Projections.TestIMRequest domainObject) : 
                base(mappingService, domainObject)
        {
            mappingService.MapTestIMRequest(domainObject, this);
        }
        
        public SampleSystem.Generated.DTO.IMRequestIdentityDTO Identity
        {
            get
            {
                return new SampleSystem.Generated.DTO.IMRequestIdentityDTO(this.Id);
            }
        }
    }
    
    [Framework.DomainDriven.DTOFileTypeAttribute(typeof(SampleSystem.Domain.Projections.TestIMRequestDetail), "ProjectionDTO", Framework.DomainDriven.Serialization.DTORole.Client)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="SampleSystem")]
    public partial class TestIMRequestDetailProjectionDTO : SampleSystem.Generated.DTO.BasePersistentDTO, Framework.Persistent.IIdentityObjectContainer<SampleSystem.Generated.DTO.IMRequestDetailIdentityDTO>
    {
        
        public TestIMRequestDetailProjectionDTO()
        {
        }
        
        public TestIMRequestDetailProjectionDTO(SampleSystem.Generated.DTO.ISampleSystemDTOMappingService mappingService, SampleSystem.Domain.Projections.TestIMRequestDetail domainObject) : 
                base(mappingService, domainObject)
        {
            mappingService.MapTestIMRequestDetail(domainObject, this);
        }
        
        public SampleSystem.Generated.DTO.IMRequestDetailIdentityDTO Identity
        {
            get
            {
                return new SampleSystem.Generated.DTO.IMRequestDetailIdentityDTO(this.Id);
            }
        }
    }
    
    [Framework.DomainDriven.DTOFileTypeAttribute(typeof(SampleSystem.Domain.Projections.TestLegacyEmployee), "ProjectionDTO", Framework.DomainDriven.Serialization.DTORole.Client)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="SampleSystem")]
    public partial class TestLegacyEmployeeProjectionDTO : SampleSystem.Generated.DTO.BasePersistentDTO, Framework.Persistent.IIdentityObjectContainer<SampleSystem.Generated.DTO.EmployeeIdentityDTO>
    {
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Framework.Core.Maybe<string> Login;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid? RoleId;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RoleName;
        
        public TestLegacyEmployeeProjectionDTO()
        {
        }
        
        public TestLegacyEmployeeProjectionDTO(SampleSystem.Generated.DTO.ISampleSystemDTOMappingService mappingService, SampleSystem.Domain.Projections.TestLegacyEmployee domainObject) : 
                base(mappingService, domainObject)
        {
            mappingService.MapTestLegacyEmployee(domainObject, this);
        }
        
        public SampleSystem.Generated.DTO.EmployeeIdentityDTO Identity
        {
            get
            {
                return new SampleSystem.Generated.DTO.EmployeeIdentityDTO(this.Id);
            }
        }
    }
    
    [Framework.DomainDriven.DTOFileTypeAttribute(typeof(SampleSystem.Domain.Projections.TestLocation), "ProjectionDTO", Framework.DomainDriven.Serialization.DTORole.Client)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="SampleSystem")]
    public partial class TestLocationProjectionDTO : SampleSystem.Generated.DTO.BasePersistentDTO, Framework.Persistent.IIdentityObjectContainer<SampleSystem.Generated.DTO.LocationIdentityDTO>
    {
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name;
        
        public TestLocationProjectionDTO()
        {
        }
        
        public TestLocationProjectionDTO(SampleSystem.Generated.DTO.ISampleSystemDTOMappingService mappingService, SampleSystem.Domain.Projections.TestLocation domainObject) : 
                base(mappingService, domainObject)
        {
            mappingService.MapTestLocation(domainObject, this);
        }
        
        public SampleSystem.Generated.DTO.LocationIdentityDTO Identity
        {
            get
            {
                return new SampleSystem.Generated.DTO.LocationIdentityDTO(this.Id);
            }
        }
    }
    
    [Framework.DomainDriven.DTOFileTypeAttribute(typeof(SampleSystem.Domain.Projections.TestLocationCollectionProperties), "ProjectionDTO", Framework.DomainDriven.Serialization.DTORole.Client)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="SampleSystem")]
    public partial class TestLocationCollectionPropertiesProjectionDTO : SampleSystem.Generated.DTO.BasePersistentDTO, Framework.Persistent.IIdentityObjectContainer<SampleSystem.Generated.DTO.LocationIdentityDTO>
    {
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid[] Child_Identities;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Framework.Core.Period[] Child_Periods;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<SampleSystem.Generated.DTO.TestLocationProjectionDTO> Children;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime[] Date_Intervals;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SampleSystem.SampleSystemSecurityOperationCode[] Security_Codes;
        
        public TestLocationCollectionPropertiesProjectionDTO()
        {
        }
        
        public TestLocationCollectionPropertiesProjectionDTO(SampleSystem.Generated.DTO.ISampleSystemDTOMappingService mappingService, SampleSystem.Domain.Projections.TestLocationCollectionProperties domainObject) : 
                base(mappingService, domainObject)
        {
            mappingService.MapTestLocationCollectionProperties(domainObject, this);
        }
        
        public SampleSystem.Generated.DTO.LocationIdentityDTO Identity
        {
            get
            {
                return new SampleSystem.Generated.DTO.LocationIdentityDTO(this.Id);
            }
        }
    }
    
    [Framework.DomainDriven.DTOFileTypeAttribute(typeof(SampleSystem.Domain.Projections.TestSecurityObjItemProjection), "ProjectionDTO", Framework.DomainDriven.Serialization.DTORole.Client)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="SampleSystem")]
    public partial class TestSecurityObjItemProjectionDTO : SampleSystem.Generated.DTO.BasePersistentDTO, Framework.Persistent.IIdentityObjectContainer<SampleSystem.Generated.DTO.TestSecurityObjItemIdentityDTO>
    {
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name;
        
        public TestSecurityObjItemProjectionDTO()
        {
        }
        
        public TestSecurityObjItemProjectionDTO(SampleSystem.Generated.DTO.ISampleSystemDTOMappingService mappingService, SampleSystem.Domain.Projections.TestSecurityObjItemProjection domainObject) : 
                base(mappingService, domainObject)
        {
            mappingService.MapTestSecurityObjItemProjection(domainObject, this);
        }
        
        public SampleSystem.Generated.DTO.TestSecurityObjItemIdentityDTO Identity
        {
            get
            {
                return new SampleSystem.Generated.DTO.TestSecurityObjItemIdentityDTO(this.Id);
            }
        }
    }
    
    [Framework.DomainDriven.DTOFileTypeAttribute(typeof(SampleSystem.Domain.Projections.UnpersitentContainer), "ProjectionDTO", Framework.DomainDriven.Serialization.DTORole.Client)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="SampleSystem")]
    public partial class UnpersitentContainerProjectionDTO : SampleSystem.Generated.DTO.BaseAbstractDTO
    {
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<SampleSystem.Generated.DTO.TestLocationProjectionDTO> Locations;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Framework.Core.Period[] PeriodArray;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SampleSystem.Generated.DTO.TestBusinessUnitProjectionDTO TestBU;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TestString;
        
        public UnpersitentContainerProjectionDTO()
        {
        }
        
        public UnpersitentContainerProjectionDTO(SampleSystem.Generated.DTO.ISampleSystemDTOMappingService mappingService, SampleSystem.Domain.Projections.UnpersitentContainer domainObject) : 
                base(mappingService, domainObject)
        {
            mappingService.MapUnpersitentContainer(domainObject, this);
        }
    }
    
    [Framework.DomainDriven.DTOFileTypeAttribute(typeof(SampleSystem.Domain.Projections.VisualEmployee), "ProjectionDTO", Framework.DomainDriven.Serialization.DTORole.Client)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="SampleSystem")]
    public partial class VisualEmployeeProjectionDTO : SampleSystem.Generated.DTO.BasePersistentDTO, Framework.Persistent.IIdentityObjectContainer<SampleSystem.Generated.DTO.EmployeeIdentityDTO>
    {
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameEngFirstName;
        
        public VisualEmployeeProjectionDTO()
        {
        }
        
        public VisualEmployeeProjectionDTO(SampleSystem.Generated.DTO.ISampleSystemDTOMappingService mappingService, SampleSystem.Domain.Projections.VisualEmployee domainObject) : 
                base(mappingService, domainObject)
        {
            mappingService.MapVisualEmployee(domainObject, this);
        }
        
        public SampleSystem.Generated.DTO.EmployeeIdentityDTO Identity
        {
            get
            {
                return new SampleSystem.Generated.DTO.EmployeeIdentityDTO(this.Id);
            }
        }
    }
    
    [Framework.DomainDriven.DTOFileTypeAttribute(typeof(SampleSystem.Domain.Projections.VisualProject), "ProjectionDTO", Framework.DomainDriven.Serialization.DTORole.Client)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="SampleSystem")]
    public partial class VisualProjectProjectionDTO : SampleSystem.Generated.DTO.BasePersistentDTO, Framework.Persistent.IIdentityObjectContainer<SampleSystem.Generated.DTO.ProjectIdentityDTO>
    {
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code;
        
        public VisualProjectProjectionDTO()
        {
        }
        
        public VisualProjectProjectionDTO(SampleSystem.Generated.DTO.ISampleSystemDTOMappingService mappingService, SampleSystem.Domain.Projections.VisualProject domainObject) : 
                base(mappingService, domainObject)
        {
            mappingService.MapVisualProject(domainObject, this);
        }
        
        public SampleSystem.Generated.DTO.ProjectIdentityDTO Identity
        {
            get
            {
                return new SampleSystem.Generated.DTO.ProjectIdentityDTO(this.Id);
            }
        }
    }
}
