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
    public interface IShiftDefinitionProcessService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> GetById(int id);
        Task<ResponseModel> Add(ShiftDefinitionProcessDtoC dto);
        Task<ResponseModel> AddUserShiftDefinition(ShiftDefinitionProcessDtoC dto);
        Task<ResponseModel> Update(ShiftDefinitionProcessDtoC dto);
        Task<ResponseModel> Delete(int id);
        Task<ResponseModel> GetUserShiftDefinition(Guid userId);
     }
}
