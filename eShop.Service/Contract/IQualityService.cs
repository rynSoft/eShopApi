using System;
using techiz.Domain.Auth;
using techiz.Domain.Common;
using System.Threading.Tasks;
using techiz.Domain.Dtos;
using System.Collections.Generic;

namespace techiz.Service.Contract
{
    public interface IQualityService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> GetById(int id);
        Task<ResponseModel> GetByLineId(int id);
        Task<ResponseModel> Add(QualityDtoC dto);
        Task<ResponseModel> Update(QualityDtoC dto);
        Task<ResponseModel> UpdateState(int id);
        Task<ResponseModel> Delete(int id);
        Task<ResponseModel> QualityAndOperationAdd(QualityAndOperationDtoC dto);
        Task<QualityAndOperationDtoQ> GetQualityDetail(int id);
    }
}
