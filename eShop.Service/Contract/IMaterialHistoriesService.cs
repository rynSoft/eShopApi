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
    public interface IMaterialHistoriesService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> GetById(int id);
        Task<ResponseModel> GetAllMaterialHistories(int productionId, int workProcessRouteId);
        Task<ResponseModel> GetByCodeHistories(int workProcessRouteId,string code);

        Task<ResponseModel> ElapsedTimeCalculate( int workProcessRouteId);
        Task<ResponseModel> Add(MaterialHistoriesDtoC dto);

    }
}
