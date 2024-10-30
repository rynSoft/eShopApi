using Microsoft.AspNetCore.Mvc;
using eShop.Service.Contract;
using System.Threading.Tasks;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System;

namespace eShopApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/ShiftDefinitionProcess")]
    public class ShiftDefinitionProcessController : ControllerBase
    {
        private readonly IShiftDefinitionProcessService _shiftDefinitionProcessService;
    
        public ShiftDefinitionProcessController(IShiftDefinitionProcessService shiftDefinitionProcessService)
        {
            _shiftDefinitionProcessService = shiftDefinitionProcessService;
        }
    
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _shiftDefinitionProcessService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
    
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _shiftDefinitionProcessService.GetById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(ShiftDefinitionProcessDtoC dto)
        { 
            return await _shiftDefinitionProcessService.Add(dto);
        }
        
        [HttpPost(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(ShiftDefinitionProcessDtoC dto)
        { 
            return await _shiftDefinitionProcessService.Update(dto);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            var result = _shiftDefinitionProcessService.Delete(Id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");

        }
        [HttpGet(nameof(GetUserShiftDefinition))]
        public async Task<ResponseModel> GetUserShiftDefinition(Guid userId)
        {
            return await _shiftDefinitionProcessService.GetUserShiftDefinition(userId);
        }
        [HttpPost(nameof(AddUserShiftDefinition))]
        public async Task<ResponseModel> AddUserShiftDefinition(ShiftDefinitionProcessDtoC dto)
        {
            return await _shiftDefinitionProcessService.AddUserShiftDefinition(dto);
        }
    }
}