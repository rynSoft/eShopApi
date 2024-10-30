using Microsoft.AspNetCore.Mvc;
using eShop.Service.Contract;
using System.Threading.Tasks;
using eShop.Domain.Common;
using eShop.Domain.Dtos;

namespace eShopApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/RestCause")]
    public class RestCauseController : ControllerBase
    {
        private readonly IRestCauseService _restCauseService;
    
        public RestCauseController(IRestCauseService restCauseService)
        {
            _restCauseService = restCauseService;
        }
    
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _restCauseService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
    
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _restCauseService.GetById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
    
        // [HttpPost(nameof(Add))]
        // public IActionResult Add(RestCauseDtoC dto)
        // { 
        //     _restCauseService.Add(dto);
        //     return Ok("Data inserted");
        // }
        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(RestCauseDtoC dto)
        { 
            return await _restCauseService.Add(dto);
        }
        
        [HttpPost(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(RestCauseDtoC dto)
        { 
            return await _restCauseService.Update(dto);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            var result = _restCauseService.Delete(Id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");

        }
    }
}