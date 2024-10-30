using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace techiz.Service.Contract
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
