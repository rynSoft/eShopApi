using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Domain.Entities;
using eShop.Domain.Interfaces;

namespace eShop.Service.Contract
{
    public interface IRouteInfoUserService
    {
        Task<ResponseModel> GetAll();
        Task<RouteInfoUserDtoQ> Get(int id); 
        Task<IEnumerable<RouteInfoUserDtoQ>> GetAllAsyncProductId(int id);
        Task<ResponseModel> Add(RouteInfoUserDtoC dto);
      
        Task<ResponseModel> Update(RouteInfoUserDtoC dto);
        Task<ResponseModel> Delete(int id);

    }
}
