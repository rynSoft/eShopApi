using Microsoft.AspNetCore.Mvc;
using techiz.Service.Contract;
using System.Threading.Tasks;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Entities;

namespace techizApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/Oee")]
    public class OeeController : ControllerBase
    {
        private readonly IOeeService _oeeService;
    
        public OeeController(IOeeService oeeService)
        {
            _oeeService = oeeService;
        }
    
        [HttpGet(nameof(GetOeeList))]
        public async Task<IActionResult> GetOeeList()
        {
            var result = await _oeeService.GetOeeList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetOeeListORM))]
        public async Task<IActionResult> GetOeeListORM()
        {
            var result = await _oeeService.GetOeeListORM();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpPost(nameof(GetOeeListORMFilter))]
        public async Task<IActionResult> GetOeeListORMFilter(ShiftTargetParametersDtoQ shiftTarget)
        {
            var result = await _oeeService.GetOeeListORMFilter(shiftTarget);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetFeederStop))]
        public async Task<IActionResult> GetFeederStop()
        {
            var result = await _oeeService.GetFeederStop();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetRestCauseTimeGroup))]
        public async Task<IActionResult> GetRestCauseTimeGroup(int shiftTargetParametersId)
        {
            var result = await _oeeService.GetRestCauseTimeGroup(shiftTargetParametersId);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        

        [HttpGet(nameof(GetSmdRapor))]
        public async Task<IActionResult> GetSmdRapor()
        {
            var result = await _oeeService.GetSmdRapor();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
    }
}