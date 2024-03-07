using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using techiz.Service.Contract;
using techiz.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.AspNetCore.Http;
using techiz.Domain;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Dtos.ProductionProcessManual;
using techiz.Domain.Enum;
using techiz.Infrastructure;
using techiz.Persistence;

namespace techizApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/ProductionProcessManualTest")]
    public class ProductionProcessManualTestController : ControllerBase
    {
        private readonly IProductionProcessManualTestService _productionProcessManualTestService; 
        private readonly IAppDbContext _appDbContext;
        private IHttpContextAccessor _httpContextAccessor;
    
        public ProductionProcessManualTestController(IProductionProcessManualTestService productionProcessManualTestService,
            IHttpContextAccessor httpContextAccessor,
            IAppDbContext appDbContext
            )
        {
            _productionProcessManualTestService = productionProcessManualTestService;
            _httpContextAccessor = httpContextAccessor;
            _appDbContext = appDbContext;
        }
    
        
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _productionProcessManualTestService.GetById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(GetAllAsyncProductionProcessManualId))]
        public async Task<IActionResult> GetAllAsyncProductionProcessManualId(int id)
        {
            var result = await _productionProcessManualTestService.GetAllAsyncProductionProcessManualId(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

       

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(ProductionProcessTestDto dto)
        {

            await _productionProcessManualTestService.ElapsedTimeCalculate(dto.ProductionId);
            if (dto.QrCode != "Finish24061994")
            {
                return await _productionProcessManualTestService.Add(dto);
            }
            else
            {
                return new ResponseModel(Success:true,Message:"Finish Edildi");
            }
        }

      
        [HttpPut(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(ProductionProcessTestDto dto)
        { 
            return await _productionProcessManualTestService.Update(dto);
        }
    }
}