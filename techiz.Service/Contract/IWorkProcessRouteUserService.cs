using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;

namespace techiz.Service.Contract
{
    public interface IWorkProcessRouteUserService
    {
        Task<ResponseModel> GetAll();
        Task<WorkProcessRouteUserDtoQ> Get(int id); 
        Task<IEnumerable<WorkProcessRouteUserDtoQ>> GetAllAsyncProductId(int id);
        Task<ResponseModel> Add(WorkProcessRouteUserDtoC dto);
        Task<ResponseModel> Update(WorkProcessRouteUserDtoC dto);
        Task<ResponseModel> Delete(int id);

    }
}
