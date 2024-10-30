using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Domain.Entities;
using eShop.Domain.Interfaces;

namespace eShop.Service.Contract
{
    public interface IWorkProcessRouteService
    {
        Task<ResponseModel> GetAll();
        Task<WorkProcessRouteDtoQ> Get(int id); 
        Task<IEnumerable<WorkProcessRouteDtoQ>> GetAllAsyncProductId(int id);
        Task<IEnumerable<WorkProcessRouteDashboardDtoQ>> GetAllProductIdDashboard(int id);

        Task<ResponseModel> Add(WorkProcessRouteDtoC dto);
        Task<ResponseModel> AddorUpdateAll(List<WorkProcessRouteDtoC> dto);
        Task<ResponseModel> UpdateState(WorkProcessRouteDtoC dto);
        Task<ResponseModel> Update(WorkProcessRouteDtoC dto);
        Task<ResponseModel> GetOrderNextId(int productionId, int workProcessRouteId, int order);
        Task<ResponseModel> Delete(int id);

    }
}
