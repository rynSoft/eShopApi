using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Domain.Entities;
using eShop.Domain.Interfaces;

namespace eShop.Service.Contract
{
    public interface IRouteInfoService
    {
        Task<ResponseModel> GetAll();
        Task<RouteInfoDtoQ> Get(int id); 
        Task<IEnumerable<RouteInfoDtoQ>> GetAllAsyncProductId(int id);
        Task<ResponseModel> Add(RouteInfoDtoC dto);
        Task<ResponseModel> UpdateState(RouteInfoDtoC dto);
        Task<ResponseModel> Update(RouteInfoDtoC dto);

    }
}
