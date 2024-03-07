using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;

namespace techiz.Service.Contract
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
