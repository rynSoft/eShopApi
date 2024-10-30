using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Domain.Entities;
using eShop.Domain.Interfaces;

namespace eShop.Service.Contract
{
    public interface INonComplianceCodeService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> GetById(int id);
        Task<ResponseModel> Add(NonComplianceCodeDtoC dto);
        Task<ResponseModel> Update(NonComplianceCodeDtoC dto);
        Task<ResponseModel> Delete(int id);
     }
}
