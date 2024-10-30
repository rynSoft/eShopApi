using System;
using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShop.Service.Contract
{
    public interface IOeeService
    {
        Task<ResponseModel> GetOeeList();

        Task<ResponseModel> GetOeeListORM();
        Task<ResponseModel> GetOeeListORMFilter(ShiftTargetParametersDtoQ shiftTargetParameters);
        Task<ResponseModel> GetFeederStop();
        Task<List<RestCauseElapsedDTO>> GetRestCauseTimeGroup(int shiftTargetParametersId);

        Task<ResponseModel> GetSmdRapor();

    }
}
