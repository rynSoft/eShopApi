using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Domain;
using eShop.Domain.Entities;
using eShop.Domain.Interfaces;

namespace eShop.Service.Contract
{
    public interface IQualityUserService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> Add(QualityUserDtoC dto);
        Task<ResponseModel> GetAllAsyncProductId(int productionId);
    }
}
