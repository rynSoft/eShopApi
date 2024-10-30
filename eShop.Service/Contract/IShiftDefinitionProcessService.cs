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
