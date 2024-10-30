using Microsoft.AspNetCore.Mvc;
using eShop.Service.Contract;
using System.Threading.Tasks;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using eShop.Domain.Enum;
namespace eShopApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/Dashboard")]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _dashboardService;
        public DashboardController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        [HttpGet(nameof(GetProduction_1))]

        public async Task<IActionResult> GetProduction_1(int LineId)
        {
            var result = await _dashboardService.GetProduction_1(LineId);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetProduction_2))]

        public async Task<IActionResult> GetProduction_2()
        {
            //var result = await _dashboardService.GetProduction_2();
            //if (result is not null)
            //{
            //    return Ok(result);
            //}
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetProduction_3))]

        public async Task<IActionResult> GetProduction_3()
        {
            //var result = await _dashboardService.GetProductionHoursCount();
            //if (result is not null)
            //{
            //    return Ok(result);
            //}
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetProduction_4))]

        public async Task<IActionResult> GetProduction_4()
        {
            var result = await _dashboardService.GetProduction_4();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetProduction_5))]

        public async Task<IActionResult> GetProduction_5()
        {
            var result = await _dashboardService.GetProduction_5();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetProduction_6))]

        public async Task<IActionResult> GetProduction_6()
        {
            var result = await _dashboardService.GetProduction_6();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

    }
}