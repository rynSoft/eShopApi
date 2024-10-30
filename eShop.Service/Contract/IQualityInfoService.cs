using System;
using eShop.Domain.Auth;
using eShop.Domain.Common;
using System.Threading.Tasks;
using eShop.Domain.Dtos;

namespace eShop.Service.Contract
{
    public interface IQualityInfoService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> GetById(int id);
        Task<ResponseModel> GetByLineId(int id);
        Task<ResponseModel> Add(QualityInfoDtoC dto);
        Task<ResponseModel> Update(QualityInfoDtoC dto);
        Task<ResponseModel> Delete(int id);
        Task<ResponseModel> GetQualityOperation(int id);
        Task<ResponseModel> GetAllQuality(int id);
    }
}
