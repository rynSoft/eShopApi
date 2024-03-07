using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using techiz.Domain;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;

namespace techiz.Service.Contract
{
    public interface IProductionOperationsService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> GetById(int id);
        Task<ResponseModel> Add(ProductionOperationsDtoC dto);
        Task<ResponseModel> Update(ProductionOperationsDtoC dto);
        Task<ResponseModel> Delete(int id);
        Task<ResponseModel> GetAllQrCodeDetail(string code,int productionId ,int machineId);
        Task<ResponseModel> GetSetupVerificationDChange(int productionId,int machineId);
        Task<ResponseModel> GetProductionTimeLog(int productionId);
        Task<ResponseModel> GetProductions(string materialandLotNo);
        Task<ResponseModel> GetMaterialtoQrcode(string materialandLotNo, int productionId);

        Task<ResponseModel> ChangeBomKitData(SetupVDChangeBomKitDto dto);
        Task<ResponseModel> GetAllAsyncProductId(int productionId);
        Task<ResponseModel> GetAllProductionAndMachne(int productionId,int machineId);
        Task<ResponseModel> GetAllProductionTimeDetail(int productionId);
        Task<ResponseModel> GetAllProductionTimeDetailMachine(int productionId, int machineId);
        
        Task<ResponseModel> GetFilterAsyncProductId(int productionId,string? Code);
        
    }
}
