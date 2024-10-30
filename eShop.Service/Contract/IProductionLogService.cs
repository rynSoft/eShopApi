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
    public interface IProductionLogService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> Add(ProductionLogDtoC dto);
        Task<ResponseModel> GetAllAsyncProductId(int productionId);
    }
}
