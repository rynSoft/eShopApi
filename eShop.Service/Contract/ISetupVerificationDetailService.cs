using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Domain;
using eShop.Domain.Entities;
using eShop.Domain.Interfaces;

namespace eShop.Service.Contract
{
    public interface ISetupVerificationDetailService
    {
        Task<ResponseModel> GetAll();
        Task<SetupVerificationDetailDto> Get(int id); 
        Task<ResponseModel> Add(SetupVerificationDetailDto dto);
        Task<IEnumerable<SetupVerificationDetailDto>> GetAllAsyncProductionId(int id);
        Task<ResponseModel> Update(SetupVerificationDetailDto dto);
        Task<ResponseModel> GetAllAsyncStateProductionId(int id, int machineId);

        Task<ResponseModel> CalcUsingQuantity(int productionId,string qrCode);
        Task<ResponseModel> GetMaterialCodeWithBomKit(string materialCode, int productionId,int setNo,int machineId);
        Task<ResponseModel> YetAddedSetNoOnFeedler(int productionId,string materialCode);
   
    }
}
