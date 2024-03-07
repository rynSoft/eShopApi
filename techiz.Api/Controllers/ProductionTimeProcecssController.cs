using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using techiz.Service.Contract;
using techiz.Domain.Entities;
using System;
using System.Threading.Tasks;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Enum;

namespace techizApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/ProductionTimeProcecss")]
    public class ProductionTimeProcecssController : ControllerBase
    {
        private readonly IProductionTimeProcessService _productionTimeProcessService;
    
        public ProductionTimeProcecssController(IProductionTimeProcessService productionLogService)
        {
            _productionTimeProcessService = productionLogService;
        }
        
        [HttpGet(nameof(GetAllAsyncProductId))]
        public async Task<IActionResult> GetAllAsyncProductId(int id,ProductionProcess ps)
        {
            var result = await _productionTimeProcessService.GetAllAsyncProductId(id,ps);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
    
        [HttpPost(nameof(Start))]
        public async Task<IActionResult> Start(ProductionTimeProcessDtoC dto)
        {
            var result = await _productionTimeProcessService.Start(dto);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpPost(nameof(Pause))]
        public async Task<IActionResult> Pause(ProductionTimeProcessDtoC dto)
        {
            var result = await _productionTimeProcessService.Pause(dto);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpPost(nameof(Resume))]
        public async Task<ActionResult<ResponseModel>> Resume(ProductionTimeProcessDtoC dto)
        { 
            return await _productionTimeProcessService.Resume(dto);
        }
        
        [HttpPost(nameof(Stop))]
        public async Task<ActionResult<ResponseModel>> Stop(ProductionTimeProcessDtoC dto)
        { 
            return await _productionTimeProcessService.Stop(dto);
        }
        
        [HttpPost(nameof(StopVirtual))]
        public async Task<ActionResult<ResponseModel>> StopVirtual(ProductionTimeProcessDtoC dto)
        { 
            return await _productionTimeProcessService.StopVirtual(dto);
        }

    }
}