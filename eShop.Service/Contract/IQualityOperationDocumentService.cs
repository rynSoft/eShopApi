using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;

namespace techiz.Service.Contract
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
