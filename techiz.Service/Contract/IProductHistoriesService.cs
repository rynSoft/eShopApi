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
    public interface IProductHistoriesService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> GetById(int id);
        Task<ResponseModel> GetAllAsyncProductHistories(int workProcessRouteId, int productionId, int isProductPage);
        Task<ResponseModel> GetByQrCode(string code, int workProcessRouteId, int productionId);
        Task<ResponseModel> ElapsedTimeCalculate( int workProcessRouteId);
        Task<ResponseModel> Update(ProductHistoriesDtoC dto);

    }
}
