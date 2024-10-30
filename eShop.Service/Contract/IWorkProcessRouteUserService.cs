using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Domain.Entities;
using eShop.Domain.Interfaces;

namespace eShop.Service.Contract
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
