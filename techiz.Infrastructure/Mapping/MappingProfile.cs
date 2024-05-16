using System;
using System.Linq;
using AutoMapper;
using techiz.Domain;
using techiz.Domain.Dtos;
using techiz.Domain.Dtos.ProductionProcessManual;
using techiz.Domain.Entities;
using techiz.Domain.Enum;
using techiz.Infrastructure.ViewModel;

namespace techiz.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Production
            
            CreateMap<Production, ProductionDtoC>()
                   .ReverseMap();
            CreateMap<ProductionDtoC, Production>()
                 .ReverseMap();
            CreateMap<Production, ProductionQrcodeReportDtoC>()
                .ReverseMap();
            CreateMap<ProductionQrcodeReportDtoC, Production>()
               .ReverseMap();
            

            CreateMap<Production, ProductionDtoQ>()
                .ReverseMap();
            CreateMap<ProductionDtoQ, Production>()
                .ReverseMap();

            #endregion


            #region QualityOperationDocument

            CreateMap<QualityOperationDocument, QualityOperationDocumentDtoC>()
                   .ReverseMap();
            CreateMap<QualityOperationDocumentDtoC, QualityOperationDocument>()
                 .ReverseMap();
            CreateMap<QualityOperationDocument, QualityOperationDocumentDtoQ>()
                .ReverseMap();
            CreateMap<QualityOperationDocumentDtoQ, QualityOperationDocument>()
                .ReverseMap();

            #endregion


            #region WorkProcessRouteMaterial

            CreateMap<WorkProcessRouteMaterial, WorkProcessRouteMaterialDtoC>()
                   .ReverseMap();
            CreateMap<WorkProcessRouteMaterialDtoC, WorkProcessRouteMaterial>()
                 .ReverseMap();
            CreateMap<WorkProcessRouteMaterialDtoQ, WorkProcessRouteMaterial>()
                .ReverseMap();
            CreateMap<WorkProcessRouteMaterial, WorkProcessRouteMaterialDtoQ>()
                .ReverseMap();

            #endregion

            #region MaterialDecreaseHistory

            CreateMap<MaterialDecreaseHistory, MaterialDecreaseHistoryDtoC>()
                   .ReverseMap();
            CreateMap<MaterialDecreaseHistoryDtoC, MaterialDecreaseHistory>()
                 .ReverseMap();
            CreateMap<MaterialDecreaseHistory, MaterialDecreaseHistoryDtoQ>()
                .ReverseMap();
            CreateMap<MaterialDecreaseHistoryDtoQ, MaterialDecreaseHistory>()
     
                .ReverseMap();

            #endregion

            #region Material

            CreateMap<Material, MaterialDtoC>()
                   .ReverseMap();
            CreateMap<MaterialDtoC, Material>()
                 .ReverseMap();
            CreateMap<Material, MaterialDtoQ>()
                .ReverseMap();
            CreateMap<MaterialDtoQ, Material>()
                .ReverseMap();

            #endregion
            


            #region MaterialHistories

            CreateMap<MaterialHistories, MaterialHistoriesDtoC>()
                   .ReverseMap();
            CreateMap<MaterialHistoriesDtoC, MaterialHistories>()
                 .ReverseMap();
            CreateMap<MaterialHistories, MaterialHistoriesDtoQ>()
                .ReverseMap();
            CreateMap<MaterialHistoriesDtoQ, MaterialHistories>()
                .ReverseMap();

            #endregion


            #region QualityOperationDocument

            CreateMap<QualityOperationDocument, QualityOperationDocumentDtoC>()
                   .ReverseMap();
            CreateMap<QualityOperationDocumentDtoC, QualityOperationDocument>()
                 .ReverseMap();
            CreateMap<QualityOperationDocument, QualityOperationDocumentDtoQ>()
                .ReverseMap();
            CreateMap<QualityOperationDocumentDtoQ, QualityOperationDocument>()
                .ReverseMap();

            #endregion





            #region QualityUser

            CreateMap<QualityUser, QualityUserDtoC>()
                .ReverseMap();
            CreateMap<QualityUserDtoC, QualityUser>()
                .ReverseMap();
            CreateMap<QualityUser, QualityUserDtoQ>()
                .ReverseMap();
            CreateMap<QualityUserDtoQ, QualityUser>()
                .ReverseMap();

            #endregion
            #region Quality

            CreateMap<Quality, QualityDtoC>()
                .ReverseMap();
            CreateMap<QualityDtoC, Quality>()
                .ReverseMap();
            CreateMap<Quality, QualityDtoQ>()
                .ReverseMap();
            CreateMap<QualityDtoQ, Quality>()
                .ReverseMap();

            #endregion

            #region QualityOperation

            CreateMap<QualityOperation, QualityOperationDtoC>()
                .ReverseMap();
            CreateMap<QualityOperationDtoC, QualityOperation>()
                .ReverseMap();
            CreateMap<QualityOperation, QualityOperationDtoQ>()
                .ReverseMap();
            CreateMap<QualityOperationDtoQ, QualityOperation>()
                .ReverseMap();

            #endregion

            #region QualityInfo

            CreateMap<QualityInfo,QualityInfoDtoC>()
                .ReverseMap();
            CreateMap<QualityInfoDtoC, QualityInfo>()
                .ReverseMap();
            CreateMap<QualityInfo, QualityInfoDtoQ>()
                .ReverseMap();
            CreateMap<QualityInfoDtoQ, QualityInfo>()
                .ReverseMap();

            #endregion

            #region Line

            CreateMap<Line, LineDtoC>()
                .ReverseMap();
            CreateMap<LineDtoC, Line>()
                .ReverseMap();
            CreateMap<Line, LineDtoQ>()
                .ReverseMap();
            CreateMap<LineDtoQ, Line>()
                .ReverseMap();

            #endregion

            #region Line

            CreateMap<Camera, CameraDtoC>()
                .ReverseMap();
            CreateMap<CameraDtoC, Camera>()
                .ReverseMap();
            CreateMap<Camera, CameraDtoQ>()
                .ReverseMap();
            CreateMap<CameraDtoQ, Camera>()
                .ReverseMap();

            #endregion

            #region Product

            CreateMap<Product, ProductDtoC>()
                .ReverseMap();
            CreateMap<ProductDtoC, Product>()
                .ReverseMap();
            CreateMap<Product, ProductDtoQ>()
                  .ForMember(dest => dest.UserAdSoyAd, opt => opt.MapFrom(src => $"{src.User.Ad} {src.User.Soyad}" ))
                  .ForMember(dest => dest.CreateDate, opt => opt.MapFrom(src => $"{src.CreateDate.Value.ToString("dd.MM.yyyy HH:mm:ss")}"))
                .ReverseMap();
            CreateMap<ProductDtoQ, Product>()
                .ReverseMap();

            #endregion


            #region Product

            CreateMap<ProductHistories, ProductHistoriesDtoC>()
                .ReverseMap();
            CreateMap<ProductHistoriesDtoC, ProductHistories>()
                .ReverseMap();
            CreateMap<ProductHistories, ProductHistoriesDtoQ>()
                .ReverseMap();
            CreateMap<ProductHistoriesDtoQ, ProductHistories>()
                .ReverseMap();

            #endregion


            #region NonCompliance

            CreateMap<NonComplianceCode, NonComplianceCodeDtoC>()
                .ReverseMap();
            CreateMap<NonComplianceCodeDtoC, NonComplianceCode>()
                .ReverseMap();
            CreateMap<NonComplianceCode, NonComplianceCodeDtoQ>()
                .ReverseMap();
            CreateMap<NonComplianceCodeDtoQ, NonComplianceCode>()
                .ReverseMap();

            #endregion
            #region Machine

            CreateMap<Machine, MachineDtoC>()
                .ReverseMap();
            CreateMap<MachineDtoC, Machine>()
                .ReverseMap();
            CreateMap<Machine, MachineDtoQ>()
                .ReverseMap();
            CreateMap<MachineDtoQ, Machine>()
                .ReverseMap();
            
            #endregion
            
            #region ProductionProcessManual

            CreateMap<ProductionProcessManual, ProductionProcessManualDto>()
                .ReverseMap();
            CreateMap<ProductionProcessManualDto, ProductionProcessManual>()
                 .ReverseMap();
  
            CreateMap<ProductionProcessManual, ProductionProcessDetachFromPanelDto>()
                .ReverseMap();
            CreateMap<ProductionProcessDetachFromPanelDto, ProductionProcessManual>()
                .ReverseMap();
            CreateMap<ProductionProcessManual, ProductionProcessDisplayAssemblyDto>()
                .ReverseMap();
            CreateMap<ProductionProcessDisplayAssemblyDto, ProductionProcessManual>()
                .ReverseMap();
            CreateMap<ProductionProcessManual, ProductionProcessLabelingDto>()
                .ReverseMap();
            CreateMap<ProductionProcessLabelingDto, ProductionProcessManual>()
                .ReverseMap();
            CreateMap<ProductionProcessManual, ProductionProcessProgrammingDto>()
                .ReverseMap();
            CreateMap<ProductionProcessProgrammingDto, ProductionProcessManual>()
                .ReverseMap();
            CreateMap<ProductionProcessManualTest, ProductionProcessTestDto>()
                .ReverseMap();
            CreateMap<ProductionProcessTestDto, ProductionProcessManualTest>()
                .ReverseMap();
            CreateMap<ProductionProcessManual, ProductionManualProcessDto>()
                .ReverseMap();
            CreateMap<ProductionManualProcessDto, ProductionProcessManual>()
                .ReverseMap();

            #endregion

            #region ShiftTargetParameters
            CreateMap<ShiftTargetParametersDtoC, ShiftTargetParameters>().ReverseMap();
            CreateMap<ShiftTargetParameters, ShiftTargetParametersDtoC>()
                .ReverseMap();
            CreateMap<ShiftTargetParameters, ShiftTargetParametersDtoQ>()
                .ReverseMap();
            CreateMap<ShiftTargetParametersDtoQ, ShiftTargetParameters>()
                .ReverseMap();

  
            #endregion
            #region ShiftDefinition

            CreateMap<ShiftDefinitionDtoC, ShiftDefinition>().ReverseMap();
            CreateMap<ShiftDefinition,ShiftDefinitionDtoC>()
                .ReverseMap();
            CreateMap<ShiftDefinition, ShiftDefinitionDtoQ>()
                .ReverseMap();
            CreateMap<ShiftDefinitionDtoQ,ShiftDefinition>()
                .ReverseMap();
            
            CreateMap<ShiftDefinitionProcessDtoC, ShiftDefinitionProcess>()
                .ReverseMap();
            CreateMap<ShiftDefinitionProcess, ShiftDefinitionProcessDtoQ>()
                .ReverseMap();
            
            CreateMap<ShiftDefinitionProcess,ShiftDefinitionProcessDtoC>()
                .ReverseMap();
            CreateMap< ShiftDefinitionProcessDtoQ,ShiftDefinitionProcess>()
                .ReverseMap();
            #endregion
            
            #region ProductionMachineMatch
            
            CreateMap<ProductionMachineMatch, ProductionMachineMatchDtoQ>()
                .ReverseMap();
            CreateMap<ProductionMachineMatchDtoQ, ProductionMachineMatch>();
            CreateMap<ProductionMachineMatch, ProductionMachineMatchDtoC>()
                .ReverseMap();
            CreateMap<ProductionMachineMatchDtoC, ProductionMachineMatch>()
                .ReverseMap();
            CreateMap<ProductionMachineMatch, ProductionMachineMatchDtoU>()
                .ReverseMap();
            CreateMap<ProductionMachineMatchDtoU, ProductionMachineMatch>()
                .ReverseMap();
            
            #endregion
            
            
            #region BomKitInfo
            
            CreateMap<BomKitInfo, BomKitInfoDtoC>()
                
                .ReverseMap();
            CreateMap<BomKitInfoDtoC, BomKitInfo>()
                .ForMember(dest=> dest.Explanation,opt => opt.MapFrom(src=> src.ACIKLAMA))
                .ForMember(dest=> dest.Material,opt => opt.MapFrom(src=> src.MALZEME))
                .ForMember(dest=> dest.Quantity,opt => opt.MapFrom(src=> Convert.ToDouble(src.MIKTAR)))
                .ForMember(dest=> dest.Unit,opt => opt.MapFrom(src=> src.MIKTAR_BIRIM))
                  .ForMember(dest => dest.RollerQuantity,opt => opt.MapFrom(src => Convert.ToDouble(src.MIKTAR)))
                .ForMember(dest=> dest.SoureProductPlace,opt => opt.MapFrom(src=> src.KAYNAK_STOK_YERI))
                .ForMember(dest=> dest.Description,opt => opt.MapFrom(src=> src.NOT))
                .ForMember(dest=> dest.PartyNumber,opt => opt.MapFrom(src=> src.PARTI_NO))
                .ForMember(dest => dest.WareHouseName, opt => opt.MapFrom(src => src.DEPO))
                .ReverseMap();
            CreateMap<BomKitInfo, BomKitInfoDtoQ>()
                .ForMember(dest=> dest.WareHouseCode,opt => opt.MapFrom(src=> src.WareHouse.Code))
                .ReverseMap();
            CreateMap<BomKitInfoDtoQ, BomKitInfo>()

                .ReverseMap();
            CreateMap<BomKitInfo, BomKitInfoDtoU>()
                .ReverseMap();
            CreateMap<BomKitInfoDtoU, BomKitInfo>()
                .ReverseMap();
            
            #endregion
            
            #region RouteInfo
            
            CreateMap<RouteInfo, RouteInfoDtoC>()
                .ReverseMap();
            CreateMap<RouteInfoDtoC, RouteInfo>()
                .ForMember(dest=> dest.Explanation , opt => opt.MapFrom(src=> src.ACIKLAMA))
                .ForMember(dest=> dest.Operation,opt=> opt.MapFrom(src=> src.OPERASYON))
                .ForMember(dest=> dest.Operation,opt=> opt.MapFrom(src=> src.OPERASYON))
              
                .ReverseMap();
            CreateMap<RouteInfo, RouteInfoDtoQ>()
                .ForMember(destination => destination.KitDogrulamaState, 
                    opt => opt.MapFrom(source => Enum.GetName(typeof(RouteStatus), source.Id)))
                .ReverseMap();
            CreateMap<RouteInfoDtoQ, RouteInfo>()
                .ReverseMap();
            
            #endregion
            
            #region SetupVerificationInfo
            
            CreateMap<SetupVerificationInfo,SetupVerificationImportDto >()
                .ReverseMap();
            CreateMap<SetupVerificationImportDto,SetupVerificationInfo >()
               .ReverseMap();
            
            CreateMap<SetupVerificationInfo,SetupVerificationDetailImportDto >()
                .ReverseMap();
            CreateMap<SetupVerificationDetailImportDto,SetupVerificationInfo >()
                .ForMember(dest=> dest.SetNo , opt => opt.MapFrom(src=>  Convert.ToInt16(src.SET_NO)))
                .ForMember(dest=> dest.Barcode,opt=> opt.MapFrom(src=> src.PARTS_NAME))
                .ForMember(dest=> dest.RollerQuantity , opt => opt.MapFrom(src=>  Convert.ToInt16(src.ROLLER_QUANTITY)))
                .ForMember(dest=> dest.Decrease , opt => opt.MapFrom(src=>  Convert.ToInt16(src.DECREASE)))
                .ReverseMap();
            #endregion
            
            #region RouteInfo
            CreateMap<RouteInfo, RouteInfoDtoQ>()
                .ForMember(destination => destination.KitDogrulamaState, 
                    opt => opt.MapFrom(source => Enum.GetName(typeof(RouteStatus), source.Id)))
                .ReverseMap();
            CreateMap<RouteInfoDtoQ, RouteInfo>()
                .ReverseMap();
            #endregion
            
            #region RouteInfo
            CreateMap<RouteInfoUser, RouteInfoUserDtoQ>()
                    .ReverseMap();
            CreateMap<RouteInfoUserDtoQ, RouteInfoUser>()
                .ReverseMap();
            CreateMap<RouteInfoUser, RouteInfoUserDtoC>()
                .ReverseMap();
            CreateMap<RouteInfoUserDtoC, RouteInfoUser>()
                .ReverseMap();
            #endregion

            #region SetupVerification
            CreateMap<SetupVerification, SetupVerificationDto>()
                .ReverseMap();
            CreateMap<SetupVerificationDto, SetupVerification>()
                .ReverseMap();
            #endregion
            
            #region SetupVerificationDetail
            CreateMap<SetupVerificationDetails, SetupVerificationDetailDto>()
                .ReverseMap();
            CreateMap<SetupVerificationDetailDto, SetupVerificationDetails>()
                .ReverseMap();
            #endregion
            
            
            #region ProductionImport
            CreateMap<ProductionImportDto, ProductionDtoC>()
                .ReverseMap();
            CreateMap<ProductionImportDto, BomKitInfoDtoC>()
                .ReverseMap();
            CreateMap<ProductionImportDto, RouteInfoDtoC>()
                .ReverseMap();
            #endregion
            
            #region ProductOperations
            CreateMap<ProductionOperationsDtoC, ProductionOperations>()
                .ReverseMap();
            CreateMap<ProductionOperations, ProductionOperationsDtoC>()
                .ReverseMap();
            CreateMap<ProductionOperationsDtoQ, ProductionOperations>()
                .ReverseMap();
            CreateMap<ProductionOperations, ProductionOperationsDtoQ>()
                .ReverseMap();
             CreateMap<ProductionOperationsDto, ProductionOperations>()
                .ReverseMap();
            CreateMap<ProductionOperations, ProductionOperationsDto>()
                .ReverseMap();

            

            #endregion

            #region WareHouse

            CreateMap<WareHouseDtoU, WareHouse>()
     .ReverseMap();
            CreateMap<WareHouse, WareHouseDtoU>()
                .ReverseMap();

            CreateMap<WareHouseDtoC, WareHouse>()
                .ReverseMap();
            CreateMap<WareHouse, WareHouseDtoC>()
                .ReverseMap();
            CreateMap<WareHouseDtoQ, WareHouse>()
                .ReverseMap();
            CreateMap<WareHouse, WareHouseDtoQ>()
                .ReverseMap();
            #endregion

            #region RestCauseDtoC
            CreateMap<RestCauseDtoC, RestCause>()
                .ReverseMap();
            CreateMap<RestCause, RestCauseDtoC>()
                .ReverseMap();
            CreateMap<RestCauseDtoQ, RestCause>()
                .ReverseMap();
            CreateMap<RestCause, RestCauseDtoQ>()
                .ReverseMap();
            #endregion
            
            #region ProductionLog
            CreateMap<ProductionLogDtoC, ProductionLog>()
                .ReverseMap();
            CreateMap<ProductionLog, ProductionLogDtoC>()
                .ReverseMap();
            CreateMap<ProductionLogDtoQ, ProductionLog>()
                .ReverseMap();
            CreateMap<ProductionLog, ProductionLogDtoQ>()
                .ReverseMap();
            #endregion
            
            #region ProductionUser
            CreateMap<ProductionUserDtoC, ProductionUser>()
                .ReverseMap();
            CreateMap<ProductionUser, ProductionUserDtoC>()
                .ReverseMap();
            CreateMap<ProductionUserDtoQ, ProductionUser>()
                .ReverseMap();
            CreateMap<ProductionUser, ProductionUserDtoQ>()
                .ReverseMap();
            #endregion

            #region WorkProcessRouteUser
            CreateMap<WorkProcessRouteUserDtoC, WorkProcessRouteUser>()
                .ReverseMap();
            CreateMap<WorkProcessRouteUser, WorkProcessRouteUserDtoC>()
                .ReverseMap();
            CreateMap<WorkProcessRouteUserDtoQ, WorkProcessRouteUser>()
                .ReverseMap();
            CreateMap<WorkProcessRouteUser, WorkProcessRouteUserDtoQ>()
                .ReverseMap();
            #endregion

            #region WorkProcessRoute
            CreateMap<WorkProcessRouteDtoC, WorkProcessRoute>()
                .ReverseMap();
            CreateMap<WorkProcessRoute, WorkProcessRouteDtoC>()
                .ReverseMap();
            CreateMap<WorkProcessRouteDtoQ, WorkProcessRoute>()
                .ReverseMap();
            CreateMap<WorkProcessRoute, WorkProcessRouteDtoQ>()
                .ReverseMap();

            CreateMap<WorkProcessRoute, WorkProcessRouteDashboardDtoQ>()
                   .ReverseMap();
            CreateMap<WorkProcessRouteDashboardDtoQ, WorkProcessRoute>()
                 .ReverseMap();


            #endregion

            #region WorkProcessTemplate
            CreateMap<WorkProcessTemplateDtoC, WorkProcessTemplate>()
                .ReverseMap();
            CreateMap<WorkProcessTemplate, WorkProcessTemplateDtoC>()
                .ReverseMap();
            CreateMap<WorkProcessTemplateDtoQ, WorkProcessTemplate>()
                .ReverseMap();
            CreateMap<WorkProcessTemplate, WorkProcessTemplateDtoQ>()
                .ReverseMap();
            #endregion

            #region WorkProcessTemplate
            CreateMap<WorkProcessRouteTimeHistoriesDtoC, WorkProcessRouteTimeHistories>()
                .ReverseMap();
            CreateMap<WorkProcessRouteTimeHistories, WorkProcessRouteTimeHistoriesDtoC>()
                .ReverseMap();
            CreateMap<WorkProcessRouteTimeHistoriesDtoQ, WorkProcessRouteTimeHistories>()
                .ReverseMap();
            CreateMap<WorkProcessRouteTimeHistories, WorkProcessRouteTimeHistoriesDtoQ>()
                .ReverseMap();
            #endregion


            #region ProductionTimeProcess
            CreateMap<ProductionTimeProcessDtoC, ProductionTimeProcess>()
                 .ForMember(dest => dest.Definition, opt => opt.MapFrom(src => src.Message))
                .ReverseMap();
            CreateMap<ProductionTimeProcess, ProductionTimeProcessDtoC>()
                   .ForMember(dest => dest.Message, opt => opt.MapFrom(src => src.Definition))
                .ReverseMap();
            CreateMap<ProductionTimeProcessDtoQ, ProductionTimeProcess>()
                   .ForMember(dest => dest.Definition, opt => opt.MapFrom(src => src.Message))
                .ReverseMap();
            CreateMap<ProductionTimeProcess, ProductionTimeProcessDtoQ>()
                   .ForMember(dest => dest.Message, opt => opt.MapFrom(src => src.Definition))

                .ReverseMap();
            #endregion
            
            #region ProductionOperationsTimeLog
            CreateMap<ProductionOperationsTimeLogDtoC, ProductionOperationsTimeLog>()
                .ReverseMap();
            CreateMap<ProductionOperationsTimeLog, ProductionOperationsTimeLogDtoC>()
                .ReverseMap();
            CreateMap<ProductionOperationsTimeLogDtoQ, ProductionOperationsTimeLog>()
                .ReverseMap();
            CreateMap<ProductionOperationsTimeLog, ProductionOperationsTimeLogDtoQ>()
        
                .ReverseMap();
            #endregion
            #region SetupVerificationDChange
            CreateMap<SetupVerificationDChangeDtoC, SetupVerificationDChange>()
                .ReverseMap();
            CreateMap<SetupVerificationDChange, SetupVerificationDChangeDtoC>()
                .ReverseMap();
            CreateMap<SetupVerificationDChangeDtoQ, SetupVerificationDChange>()
                .ReverseMap();
            CreateMap<SetupVerificationDChange, SetupVerificationDChangeDtoQ>()
        
                .ReverseMap();
            #endregion
        }
    }
}
