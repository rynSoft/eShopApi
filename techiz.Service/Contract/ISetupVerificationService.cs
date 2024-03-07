using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using techiz.Domain;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;

namespace techiz.Service.Contract
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
