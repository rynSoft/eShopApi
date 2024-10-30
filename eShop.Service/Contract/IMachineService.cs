﻿using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;

namespace techiz.Service.Contract
{
    public interface IMachineService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> GetById(int id);
        Task<ResponseModel> GetByLineId(int id);
        Task<ResponseModel> Add(MachineDtoC dto);
        Task<ResponseModel> Update(MachineDtoC dto);
        Task<ResponseModel> Delete(int id);
     }
}