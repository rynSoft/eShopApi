using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;

namespace techiz.Service.Contract
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
