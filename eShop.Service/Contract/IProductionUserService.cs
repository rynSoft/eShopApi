using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Domain;
using eShop.Domain.Entities;
using eShop.Domain.Interfaces;
using System;
using eShop.Domain.Enum;

namespace eShop.Service.Contract
{
    public interface IProductionUserService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> Add(ProductionUserDtoC dto);
        Task<ResponseModel> GetAllAsyncProductId(int productionId);
        Task<ResponseModel> Delete(int productionId, Guid userId, ProductionProcess ps);
    }
}
