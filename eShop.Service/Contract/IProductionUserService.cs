using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using techiz.Domain;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;
using System;
using techiz.Domain.Enum;

namespace techiz.Service.Contract
{
    public interface IProductionUserService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> Add(ProductionUserDtoC dto);
        Task<ResponseModel> GetAllAsyncProductId(int productionId);
        Task<ResponseModel> Delete(int productionId, Guid userId, ProductionProcess ps);
    }
}
