
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Threading.Tasks;
using eShop.Domain.Dtos.ProductionProcessManual;
using eShop.Domain.Entities;

namespace eShop.Service.Contract
{
    public interface IMaterialService
    {
        Task<ResponseModel> GetAll();
        Task<MaterialDtoQ> Get(int id);
        Task<ResponseModel> GetAllMaterialId(int productionId);
        Task<ResponseModel> Add(MaterialDtoC dto);
        Task<ResponseModel> ImportToAdd(MaterialImportDtoC dto);
        Task<ResponseModel> Delete(int id);
        Task<ResponseModel> Update(MaterialDtoC dto);
        Task<ResponseModel> UpdateRemainQuantity(Material entity);
        Task<ResponseModel> GetByCodeMaterial(int productionId, string code, int workProcessRouteId);
    }
}
