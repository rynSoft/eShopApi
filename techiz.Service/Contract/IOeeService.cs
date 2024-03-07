using System;
using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace techiz.Service.Contract
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
