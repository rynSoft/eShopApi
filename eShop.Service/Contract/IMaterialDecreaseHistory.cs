
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Threading.Tasks;
using eShop.Domain.Dtos.ProductionProcessManual;
using eShop.Domain.Entities;

namespace eShop.Service.Contract
{
    public interface IMaterialDecreaseHistoryService
    {
        Task<ResponseModel> GetAll();
        Task<MaterialDecreaseHistoryDtoQ> Get(int id);
        Task<ResponseModel> GetProductHistoryId(int productHistoryId);
        Task<ResponseModel> Add(MaterialDecreaseHistoryDtoC dto);
        Task<ResponseModel> Delete(int id);
    }
}
