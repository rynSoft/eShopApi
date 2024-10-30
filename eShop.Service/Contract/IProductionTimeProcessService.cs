using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Domain;
using eShop.Domain.Entities;
using eShop.Domain.Enum;
using eShop.Domain.Interfaces;
using ProductionProcess = eShop.Domain.Enum.ProductionProcess;


namespace eShop.Service.Contract
{
    public interface IProductionTimeProcessService
    {
        Task<ResponseModel> Start(ProductionTimeProcessDtoC dto);
        Task<ResponseModel> Pause(ProductionTimeProcessDtoC dto);
        Task<ResponseModel> Resume(ProductionTimeProcessDtoC dto);
        Task<IEnumerable<ProductionTimeProcessDtoQ>> GetAllAsyncProductId(int id,ProductionProcess ps);
        Task<ResponseModel> Stop(ProductionTimeProcessDtoC dto);
        Task<ResponseModel> StopVirtual(ProductionTimeProcessDtoC dto);
        
    }
}
