using Microsoft.AspNetCore.Mvc;
using techiz.Service.Contract;
using System.Threading.Tasks;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System;

namespace techizApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/ShiftTargetParameters")]
    public class ShiftTargetParametersControlller : ControllerBase
    {
        private readonly IShiftTargetParametersService _shiftTargetParametersService;
    
        public ShiftTargetParametersControlller(IShiftTargetParametersService shiftTargetParametersService)
        {
            _shiftTargetParametersService = shiftTargetParametersService;
        }
    
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _shiftTargetParametersService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
    
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _shiftTargetParametersService.GetById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetToday))]
        public async Task<IActionResult> GetToday(Guid userId)
        {
            var result = await _shiftTargetParametersService.GetToday( userId);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetNowShiftTarget))]
        public async Task<IActionResult> GetNowShiftTarget()
        {
            var result = await _shiftTargetParametersService.GetNowShiftTarget();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        
        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(ShiftTargetParametersDtoC dto)
        { 
            return await _shiftTargetParametersService.Add(dto);
        }



        
        [HttpPost(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(ShiftTargetParametersDtoC dto)
        { 
            return await _shiftTargetParametersService.Update(dto);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            var result = _shiftTargetParametersService.Delete(Id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");

        }
    }
}