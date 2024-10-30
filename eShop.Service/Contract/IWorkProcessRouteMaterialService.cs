
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Threading.Tasks;
using eShop.Domain.Dtos.ProductionProcessManual;
using eShop.Domain.Entities;

namespace eShop.Service.Contract
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
