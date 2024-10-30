using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Domain;
using eShop.Domain.Entities;
using eShop.Domain.Interfaces;

namespace eShop.Service.Contract
{
    public interface ISetupVerificationService
    {
        Task<ResponseModel> GetAll();
        Task<SetupVerificationDto> Get(int id); 
        Task<ResponseModel> Add(SetupVerificationDto dto);
        Task<IEnumerable<SetupVerificationDto>> GetAllAsyncProductId(int id);
        Task<ResponseModel> Update(SetupVerificationDto dto);

    }
}
