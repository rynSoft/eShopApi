using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Domain.Entities;
using eShop.Domain.Interfaces;

namespace eShop.Service.Contract
{
    public interface IWorkProcessRouteTemplateService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> GetAllFilter();
        
        Task<ResponseModel> GetById(int id);
        Task<ResponseModel> Add(WorkProcessRouteTemplateDtoC dto);
        Task<ResponseModel> Update(WorkProcessRouteTemplateDtoC dto);
        Task<ResponseModel> Delete(int id);
     }
}
