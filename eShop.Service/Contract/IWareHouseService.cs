using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Domain.Entities;
using eShop.Domain.Interfaces;

namespace eShop.Service.Contract
{
    public interface IWareHouseService
    {
        Task<ResponseModel> GetAll();
        Task<WareHouseDtoQ> Get(int id); 
        Task<int?> GetBynemToId(string name); 
        Task<ResponseModel> Add(WareHouseDtoC dto);
        Task<ResponseModel> AddNewBarcode(WareHouseDtoBU dto);
        Task<ResponseModel> Update(WareHouseDtoU dto);
        
        Task<ResponseModel> Delete(int id);

 
    }
}
