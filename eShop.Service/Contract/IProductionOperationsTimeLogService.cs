using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Domain.Entities;
using eShop.Domain.Interfaces;

namespace eShop.Service.Contract
{
    public interface IProductionOperationsTimeLogService
    {
        Task<ResponseModel> GetAll(int productionId);
        Task<ResponseModel> GetAllMachine(int productionId,int machineId);
        Task<ResponseModel> Add(ProductionOperationsTimeLogDtoC dto);
    }
}
