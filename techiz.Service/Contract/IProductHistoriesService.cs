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
        Task<ResponseModel> GetAllAsyncProductHistories(int workProcessRouteId);
        Task<ResponseModel> GetByQrCodeHistories(int workProcessRouteId,string code);
        Task<ResponseModel> GetByQrCodeProduct(int productionId,string code);

        Task<ResponseModel> ElapsedTimeCalculate( int workProcessRouteId);
        Task<ResponseModel> Add(ProductHistoriesDtoC dto);

    }
}
