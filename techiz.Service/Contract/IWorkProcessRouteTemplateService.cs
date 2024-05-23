﻿using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;

namespace techiz.Service.Contract
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
