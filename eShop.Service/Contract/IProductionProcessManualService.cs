using System;
using techiz.Domain.Auth;
using techiz.Domain.Common;
using System.Threading.Tasks;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using techiz.Domain.Dtos.ProductionProcessManual;
using techiz.Domain.Entities;
using techiz.Domain.Enum;

namespace techiz.Service.Contract
{
    public interface IProductionProcessManualService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> GetById(int id);
        Task<ResponseModel> GetAllAsyncProductionProcessManualId(int productionId, ProductionProcess process,ProductionProcess previousProcess);
        Task<ResponseModel> GetByQrCode(string code,int productionId, ProductionProcess process, ProductionProcess previousProcess);
        
        Task<ResponseModel> Add(ProductionManualProcessDto dto);
        Task<ResponseModel> LabelingUpdate(ProductionProcessLabelingDto dto);
        Task<ResponseModel> ElapsedTimeCalculate(ProductionProcess process, int productionId,ProductionProcessManual ps);
        
        Task<ResponseModel> DisplayAssemblyUpdate(ProductionProcessDisplayAssemblyDto dto);
        Task<ResponseModel> ProgrammingUpdate(ProductionProcessProgrammingDto dto);
        Task<ResponseModel> DetachFromPanelUpdate(ProductionProcessDetachFromPanelDto dto);
    }
}
