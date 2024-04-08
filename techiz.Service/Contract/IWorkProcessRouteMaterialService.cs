
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Threading.Tasks;
using techiz.Domain.Dtos.ProductionProcessManual;
using techiz.Domain.Entities;

namespace techiz.Service.Contract
{
    public interface IWorkProcessRouteMaterialService
    {
        Task<ResponseModel> GetAll();
        Task<WorkProcessRouteMaterialDtoQ> Get(int id);
        Task<ResponseModel> GetAllWorkProcessRouteMaterialId(int productionId);
        Task<ResponseModel> Add(WorkProcessRouteMaterialDtoC dto);
        Task<ResponseModel> Delete(int id);
        Task<ResponseModel> Update(WorkProcessRouteMaterialDtoC dto);
    }
}
