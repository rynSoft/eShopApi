using Microsoft.AspNetCore.Mvc;
using eShop.Service.Contract;
using System.Threading.Tasks;
using eShop.Domain.Common;
using eShop.Domain.Dtos;

namespace eShopApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/NonComplianceCode")]
    public class NonComplianceCodeController : ControllerBase
    {
        private readonly INonComplianceCodeService _NonCompService;
    
        public NonComplianceCodeController(INonComplianceCodeService NonComplianceCodeService)
        {
            _NonCompService = NonComplianceCodeService;
        }
    
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _NonCompService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
    
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _NonCompService.GetById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
    
        // [HttpPost(nameof(Add))]
        // public IActionResult Add(LineDtoC dto)
        // { 
        //     _LineService.Add(dto);
        //     return Ok("Data inserted");
        // }
        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(NonComplianceCodeDtoC dto)
        { 
            return await _NonCompService.Add(dto);
        }
        
        [HttpPost(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(NonComplianceCodeDtoC dto)
        { 
            return await _NonCompService.Update(dto);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            var result = _NonCompService.Delete(Id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");

        }
    }
}