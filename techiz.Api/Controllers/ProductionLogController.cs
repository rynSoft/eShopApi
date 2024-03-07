using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using techiz.Service.Contract;
using techiz.Domain.Entities;
using System;
using System.Threading.Tasks;
using techiz.Domain.Common;
using techiz.Domain.Dtos;

namespace techizApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/ProductionLog")]
    public class ProductionLogController : ControllerBase
    {
        private readonly IProductionLogService _productionLogService;
    
        public ProductionLogController(IProductionLogService productionLogService)
        {
            _productionLogService = productionLogService;
        }
    
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productionLogService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(GetAllAsyncProductId))]
        public async Task<IActionResult> GetAllAsyncProductId(int id)
        {
            var result = await _productionLogService.GetAllAsyncProductId(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(ProductionLogDtoC dto)
        { 
            return await _productionLogService.Add(dto);
        }

    }
}