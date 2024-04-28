
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Threading.Tasks;
using techiz.Domain.Dtos.ProductionProcessManual;
using techiz.Domain.Entities;

namespace techiz.Service.Contract
{
    public interface IMaterialService
    {
        Task<ResponseModel> GetAll();
        Task<MaterialDtoQ> Get(int id);
        Task<ResponseModel> GetAllMaterialId(int productionId);
        Task<ResponseModel> Add(MaterialDtoC dto);
        Task<ResponseModel> Delete(int id);
        Task<ResponseModel> Update(MaterialDtoC dto);
        Task<ResponseModel> UpdateRemainQuantity(Material entity);
        Task<ResponseModel> GetByCodeMaterial(int productionId, string code, int workProcessRouteId);
    }
}
