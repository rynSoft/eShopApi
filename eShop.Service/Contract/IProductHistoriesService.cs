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
    public interface IProductHistoriesService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> GetById(int id);
        Task<ResponseModel> GetAllAsyncProductHistories(int workProcessRouteId);
        Task<ResponseModel> GetByQrCodeHistories(int workProcessRouteId,string code);

        Task<ResponseModel> ElapsedTimeCalculate( int workProcessRouteId);
        Task<ResponseModel> Add(ProductHistoriesDtoC dto);

    }
}
