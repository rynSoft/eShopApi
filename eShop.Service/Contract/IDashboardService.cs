using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using eShop.Domain.Entities;


namespace eShop.Service.Contract
{
    public interface IDashboardService
    {
        Task<ResponseModel> GetProduction_1(int LineId);
        Task<List<RestCauseElapsedDTO>> GetRestCauseTimeGroup(int productionId);
        Task<List<ProductionHoursCount>> GetProductionHoursCount(int productionId);
        Task<ResponseModel> GetProduction_4();
        Task<ResponseModel> GetProduction_5();
        Task<ResponseModel> GetProduction_6();


    }
}
