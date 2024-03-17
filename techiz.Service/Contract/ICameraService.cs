using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;

namespace techiz.Service.Contract
{
    public interface ICameraService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> GetById(int id);
        Task<ResponseModel> GetByLineId(int id);
        Task<ResponseModel> Add(CameraDtoC dto);
        Task<ResponseModel> Update(CameraDtoC dto);
        Task<ResponseModel> Delete(int id);
     }
}
