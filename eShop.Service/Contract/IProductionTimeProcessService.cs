using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using techiz.Domain;
using techiz.Domain.Entities;
using techiz.Domain.Enum;
using techiz.Domain.Interfaces;
using ProductionProcess = techiz.Domain.Enum.ProductionProcess;


namespace techiz.Service.Contract
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
