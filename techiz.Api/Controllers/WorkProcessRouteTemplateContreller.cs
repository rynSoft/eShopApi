using Microsoft.AspNetCore.Mvc;
using techiz.Service.Contract;
using System.Threading.Tasks;
using techiz.Domain.Common;
using techiz.Domain.Dtos;

namespace techizApi.Controllers
{
    [ApiController]
    [Route("api/WorkProcessRouteTemplate")]
    public class WorkProcessRouteTemplateContreller : ControllerBase
    {
        private readonly IWorkProcessRouteTemplateService _workProcessRouteTemplateService;
    
        public WorkProcessRouteTemplateContreller(IWorkProcessRouteTemplateService workProcessRouteTemplateService)
        {
            _workProcessRouteTemplateService = workProcessRouteTemplateService;
        }
    
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _workProcessRouteTemplateService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetAllFilter))]
        public async Task<IActionResult> GetAllFilter()
        {
            var result = await _workProcessRouteTemplateService.GetAllFilter();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _workProcessRouteTemplateService.GetById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
    
        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(WorkProcessRouteTemplateDtoC dto)
        { 
            return await _workProcessRouteTemplateService.Add(dto);
        }
        
        [HttpPost(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(WorkProcessRouteTemplateDtoC dto)
        { 
            return await _workProcessRouteTemplateService.Update(dto);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            var result = _workProcessRouteTemplateService.Delete(Id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");

        }
    }
}