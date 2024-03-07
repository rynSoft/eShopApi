using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;

namespace techiz.Service.Contract
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
