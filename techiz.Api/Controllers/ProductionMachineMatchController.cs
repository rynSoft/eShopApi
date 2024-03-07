using Microsoft.AspNetCore.Mvc;
using techiz.Service.Contract;
using System.Threading.Tasks;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
namespace techizApi.Controllers
{
    [ApiController]
    [Route("api/ProductionMachineMatch")]
    public class ProductionMachineMatchController : ControllerBase
    {
        private readonly IProductionMachineMatchService _productionMachineMatchService;
    
        public ProductionMachineMatchController(IProductionMachineMatchService productionMachineMatchService)
        {
            _productionMachineMatchService = productionMachineMatchService;
        }
    
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productionMachineMatchService.GetAll();

            if (result is not null)
            {

                return Ok(result);
            }
            return BadRequest("No records found");
        }
    
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _productionMachineMatchService.GetById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }


        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(ProductionMachineMatchDtoC dto)
        { 
            return await _productionMachineMatchService.Add(dto);
        }
        
        [HttpPost(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(ProductionMachineMatchDtoU dto)
        {   
            return await _productionMachineMatchService.Update(dto);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            var result = _productionMachineMatchService.Delete(Id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");

        }
    }
}