
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Threading.Tasks;

namespace techiz.Service.Contract
{
    public interface IProductService
    {
        Task<ResponseModel> GetAll();
        Task<ProductionDtoQ> Get(int id);
        Task<ResponseModel> GetAllProductionId(int productionId);
        Task<ResponseModel> Add(ProductDtoC dto);
        Task<ResponseModel> Delete(int id);
    }
}
