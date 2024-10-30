using System;
using techiz.Domain.Auth;
using techiz.Domain.Common;
using System.Threading.Tasks;
using techiz.Domain.Dtos;

namespace techiz.Service.Contract
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
