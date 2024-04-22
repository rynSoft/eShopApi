
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Threading.Tasks;
using techiz.Domain.Dtos.ProductionProcessManual;
using techiz.Domain.Entities;

namespace techiz.Service.Contract
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
