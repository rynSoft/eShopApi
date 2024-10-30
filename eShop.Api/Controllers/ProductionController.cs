using Microsoft.AspNetCore.Mvc;
using techiz.Service.Contract;
using System.Threading.Tasks;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Enum;
using techiz.Service.Implementation;

namespace techizApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/Production")]
    public class ProductionController : ControllerBase
    {
        private readonly IProductionService _productionService;
        public ProductionController(IProductionService productionService)
        {
            _productionService = productionService;
          }
    
        [HttpGet(nameof(GetAll))]

        public async Task<IActionResult> GetAll()
        {
            var result = await _productionService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetAllQrCodeDetail))]

        public async Task<IActionResult> GetAllQrCodeDetail(int productionId)
        {
            var result = await _productionService.GetAllQrCodeDetail(productionId);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetProductionProcessAll))]

        public async Task<IActionResult> GetProductionProcessAll(ProductionProcess ps)
        {
            var result = await _productionService.GetProductionProcessAll(ps);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _productionService.Get(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }

        [HttpGet(nameof(GetOperationState))]
        public async Task<IActionResult> GetOperationState(int id, int routeId)
        {
            var result = await _productionService.GetOperationState(id, routeId);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }
        
        [HttpGet(nameof(SetEstimatedTime))]
        public async Task<IActionResult> SetEstimatedTime(int id, int? estimatedTime, int? panelCardCount)
        {
            var result = await _productionService.SetEstimatedTime(id,estimatedTime, panelCardCount);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }
    
        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(ProductionDtoC dto)
        { 
            return await _productionService.Add(dto);
        }



        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            var result = _productionService.Delete(Id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");

        }
    }
}