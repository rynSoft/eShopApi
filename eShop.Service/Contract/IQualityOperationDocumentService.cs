using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Domain.Entities;
using eShop.Domain.Interfaces;

namespace eShop.Service.Contract
{
    public interface IQualityOperationDocumentService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> GetById(int id);
        Task<ResponseModel> Add(QualityOperationDocumentDtoC dto);
        
        Task<ResponseModel> AddList(QualityOperationDocumentDtoC[] dto);
        Task<ResponseModel> OperationDocument(QualityOperationDocumentDtoC[] dto);
        
        Task<ResponseModel> Update(QualityOperationDocumentDtoC dto);
        Task<ResponseModel> OperationDocumentList(int id);
        Task<ResponseModel> Delete(int id);
     }
}
