using System.Collections.Generic;
using System.Threading.Tasks;
using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Entities;


namespace techiz.Service.Contract
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
