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
    public interface IProductionService
    {
        Task<ResponseModel> GetAll();
        Task<ProductionDtoQ> Get(int id);
        Task<ResponseModel> GetAllQrCodeDetail(int productionId);
        Task<ProductionOperationDtoQ> GetOperationState(int id, int routeId);
        Task<ResponseModel> GetProductionProcessAll(ProductionProcess ps);
        Task<ResponseModel> Add(ProductionDtoC dto);
        Task<ResponseModel> Delete(int id);
        Task<ResponseModel> SetEstimatedTime(int id, int? estimatedTime, int? panelCardCount);

    }
}
