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
    public interface IWorkCentreService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> Add(WorkCentreDtoC dto);
        Task<WorkCentre> GetWorkCentre(int id);
    }
}
