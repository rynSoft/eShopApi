using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShop.Service.Contract
{
    public interface IWorkProcessRouteTimeHistoriesService
    {
        Task<ResponseModel> Start(WorkProcessRouteTimeHistoriesDtoC dto);
        Task<ResponseModel> Pause(WorkProcessRouteTimeHistoriesDtoC dto);
        Task<ResponseModel> Resume(WorkProcessRouteTimeHistoriesDtoC dto);
        Task<IEnumerable<WorkProcessRouteTimeHistoriesDtoQ>> GetAllAsyncRouteId(int id);
        Task<ResponseModel> Stop(WorkProcessRouteTimeHistoriesDtoC dto);
        Task<ResponseModel> StopVirtual(WorkProcessRouteTimeHistoriesDtoC dto);
        
    }
}
