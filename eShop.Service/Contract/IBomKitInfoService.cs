using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Domain.Entities;
using eShop.Domain.Interfaces;

namespace eShop.Service.Contract
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
