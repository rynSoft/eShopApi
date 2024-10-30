using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Domain.Entities;
using eShop.Domain.Interfaces;
using System;

namespace eShop.Service.Contract
{
    public interface IShiftTargetParametersService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> GetById(int id);
        Task<ResponseModel> GetToday(Guid userId);
        Task<ResponseModel> GetNowShiftTarget();
        Task<ResponseModel> Add(ShiftTargetParametersDtoC dto);
        Task<ResponseModel> Update(ShiftTargetParametersDtoC dto);
        Task<ResponseModel> Delete(int id);
     }
}
