using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;

namespace techiz.Service.Contract
{
    public interface IProductionOperationsTimeLogService
    {
        Task<ResponseModel> GetAll(int productionId);
        Task<ResponseModel> GetAllMachine(int productionId,int machineId);
        Task<ResponseModel> Add(ProductionOperationsTimeLogDtoC dto);
    }
}
