using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;
using System;

namespace techiz.Service.Contract
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
