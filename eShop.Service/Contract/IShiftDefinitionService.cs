using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Domain.Entities;
using eShop.Domain.Interfaces;

namespace eShop.Service.Contract
{
    public interface IShiftDefinitionService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> GetAllFilter();
        Task<ResponseModel> GetById(int id);
        Task<ResponseModel> Add(ShiftDefinitionDtoC dto);
        Task<ResponseModel> Update(ShiftDefinitionDtoC dto);
        Task<ResponseModel> Delete(int id);
     }
}
