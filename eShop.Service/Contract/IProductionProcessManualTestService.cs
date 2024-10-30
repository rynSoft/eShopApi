using System;
using techiz.Domain.Auth;
using techiz.Domain.Common;
using System.Threading.Tasks;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using techiz.Domain.Dtos.ProductionProcessManual;
using techiz.Domain.Entities;
using techiz.Domain.Enum;

namespace techiz.Service.Contract
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
