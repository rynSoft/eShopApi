using System;
using eShop.Domain.Auth;
using eShop.Domain.Common;
using System.Threading.Tasks;
using eShop.Domain.Dtos;

namespace eShop.Service.Contract
{
    public interface IQualityOperationService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> GetById(int id);
        Task<ResponseModel> GetByLineId(int id);
        Task<ResponseModel> Add(QualityOperationDtoC dto);
        Task<ResponseModel> Update(QualityOperationDtoC dto);
        Task<ResponseModel> Delete(int id);
        Task<ResponseModel> GetApprowingUserList();
        Task<ResponseModel> GetUserOperationList();
        Task<ResponseModel> GetUserAutherizationList();
        Task<ResponseModel> GetUserApprowingDetail(int id);
        Task<ResponseModel> GetUserApprowingDetailConfirmation(int id);
        Task<ResponseModel> UpdateConfirmation(int id);
        Task<ResponseModel> GetUserAutherizationDetail(int id);
        Task<ResponseModel> QualityOperationEndProcess(int id);
        
        Task<ResponseModel> StartOperation(int id);

    }
}
