using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;

namespace techiz.Service.Contract
{
    public interface IBomKitInfoService
    {
        Task<ResponseModel> GetAll();
        Task<BomKitInfoDtoQ> Get(int id); 
        Task<ResponseModel> Add(BomKitInfoDtoC dto);
        Task<IEnumerable<BomKitInfoDtoQ>> GetAllAsyncProductId(int id);
        Task<ResponseModel> Update(BomKitInfoDtoU dto);

        Task<ResponseModel> UpdateWareHouse(int productionId, int wareHouseId, string House);

    }
}
