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
    [Route("api/ProductionOperationsTimeLog")]
    public class ProductionOperationsTimeLogController : ControllerBase
    {
        private readonly IProductionOperationsTimeLogService _productionLogService;
    
        public ProductionOperationsTimeLogController(IProductionOperationsTimeLogService productionLogService)
        {
            _productionLogService = productionLogService;
        }
    
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll(int productionId)
        {
            var result = await _productionLogService.GetAll(productionId);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetAllMachine))]
        public async Task<IActionResult> GetAllMachine(int productionId,int machineId)
        {
            var result = await _productionLogService.GetAllMachine(productionId,machineId);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(ProductionOperationsTimeLogDtoC dto)
        { 
            return await _productionLogService.Add(dto);
        }

    }
}