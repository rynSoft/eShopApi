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
