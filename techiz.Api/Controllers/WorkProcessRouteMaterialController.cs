using Microsoft.AspNetCore.Mvc;
using techiz.Service.Contract;
using System.Threading.Tasks;
using techiz.Domain.Common;
using techiz.Domain.Dtos;

namespace techizApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/WorkProcessRouteMaterial")]
    public class WorkProcessRouteMaterialController : ControllerBase
    {
        private readonly IWorkProcessRouteMaterialService _workProcessRouteMaterialService;
    
        public WorkProcessRouteMaterialController(IWorkProcessRouteMaterialService workProcessRouteMaterialService)
        {
            _workProcessRouteMaterialService = workProcessRouteMaterialService;
        }
    
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _workProcessRouteMaterialService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }


        //[HttpGet(nameof(GetById))]
        //public async Task<IActionResult> GetById(int id)
        //{
        //    var result = await _workProcessRouteMaterialService.GetById(id);
        //    if (result is not null)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest("No records found");
        //}
    
        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(WorkProcessRouteMaterialDtoC dto)
        { 
            return await _workProcessRouteMaterialService.Add(dto);
        }
        
        [HttpPost(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(WorkProcessRouteMaterialDtoC dto)
        { 
            return await _workProcessRouteMaterialService.Update(dto);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            var result = await _workProcessRouteMaterialService.Delete(Id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
    }
}