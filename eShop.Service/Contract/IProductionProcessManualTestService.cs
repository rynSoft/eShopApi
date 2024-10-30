using System;
using eShop.Domain.Auth;
using eShop.Domain.Common;
using System.Threading.Tasks;
using eShop.Domain.Dtos;
using System.Collections.Generic;
using eShop.Domain.Dtos.ProductionProcessManual;
using eShop.Domain.Entities;
using eShop.Domain.Enum;

namespace eShop.Service.Contract
{
    public interface IProductionProcessManualTestService
    {

        Task<ResponseModel> GetById(int id);
        Task<ResponseModel> GetAllAsyncProductionProcessManualId(int productionId);
        
        Task<ResponseModel> Add(ProductionProcessTestDto dto);
        Task<ResponseModel> ElapsedTimeCalculate( int productionId);

        Task<ResponseModel> Update(ProductionProcessTestDto dto);
    }
}
