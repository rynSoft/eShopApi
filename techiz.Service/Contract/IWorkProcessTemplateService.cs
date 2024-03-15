using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;

namespace techiz.Service.Contract
{
    public interface IWorkProcessTemplateService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel>  GetAllListProductionId(int productionId);
        Task<ResponseModel> GetNavListProductionId(int productionId);
        Task<ResponseModel> GetAllFilter();
        
        Task<ResponseModel> GetById(int id);
        Task<ResponseModel> Add(WorkProcessTemplateDtoC dto);
        Task<ResponseModel> Update(WorkProcessTemplateDtoC dto);
        Task<ResponseModel> Delete(int id);
     }
}
