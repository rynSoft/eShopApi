using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;

namespace techiz.Service.Contract
{
    public interface IWorkProcessRouteService
    {
        Task<ResponseModel> GetAll();
        Task<WorkProcessRouteDtoQ> Get(int id); 
        Task<IEnumerable<WorkProcessRouteDtoQ>> GetAllAsyncProductId(int id);
        Task<ResponseModel> Add(WorkProcessRouteDtoC dto);
        Task<ResponseModel> AddorUpdateAll(List<WorkProcessRouteDtoC> dto);
        Task<ResponseModel> UpdateState(WorkProcessRouteDtoC dto);
        Task<ResponseModel> Update(WorkProcessRouteDtoC dto);

    }
}
