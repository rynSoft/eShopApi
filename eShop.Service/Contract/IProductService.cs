
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Threading.Tasks;
using techiz.Domain.Dtos.ProductionProcessManual;
using techiz.Domain.Entities;

namespace techiz.Service.Contract
{
    public interface IProductService
    {
        Task<ResponseModel> GetAll();
        Task<ProductDtoQ> Get(int id);
        Task<ResponseModel> GetAllProductId(int productionId);
        Task<ResponseModel> Add(ProductDtoC dto);
        Task<ResponseModel> Delete(int id);
        Task<ResponseModel> Update(ProductDtoC dto);
        Task<ResponseModel> ProductNextOrder(string qrCode, int productionId);
        Task<ResponseModel> GetByQrCodeProduct(int productionId, string code, int workProcessRouteId);
    }
}
