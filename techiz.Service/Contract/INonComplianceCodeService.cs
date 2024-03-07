using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;

namespace techiz.Service.Contract
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
