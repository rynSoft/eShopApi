
using Microsoft.AspNetCore.Mvc;
using techiz.Service.Contract;
using System.Threading.Tasks;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Enum;

namespace techizApi.Controllers
{
    [ApiController]
    [Route("api/WorkProcessRouteTimeHistories")]
    public class WorkProcessRouteTimeHistoriesController : ControllerBase
    {
        private readonly IWorkProcessRouteTimeHistoriesService _workProcessRouteTimeHistoriesService;
    
        public WorkProcessRouteTimeHistoriesController(IWorkProcessRouteTimeHistoriesService workProcessRouteTimeHistoriesService)
        {
            _workProcessRouteTimeHistoriesService = workProcessRouteTimeHistoriesService;
        }
        
        [HttpGet(nameof(GetAllAsyncProductId))]
        public async Task<IActionResult> GetAllAsyncProductId(int id)
        {
            var result = await _workProcessRouteTimeHistoriesService.GetAllAsyncRouteId(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
    
        [HttpPost(nameof(Start))]
        public async Task<IActionResult> Start(WorkProcessRouteTimeHistoriesDtoC dto)
        {
            var result = await _workProcessRouteTimeHistoriesService.Start(dto);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpPost(nameof(Pause))]
        public async Task<IActionResult> Pause(WorkProcessRouteTimeHistoriesDtoC dto)
        {
            var result = await _workProcessRouteTimeHistoriesService.Pause(dto);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpPost(nameof(Resume))]
        public async Task<ActionResult<ResponseModel>> Resume(WorkProcessRouteTimeHistoriesDtoC dto)
        { 
            return await _workProcessRouteTimeHistoriesService.Resume(dto);
        }
        
        [HttpPost(nameof(Stop))]
        public async Task<ActionResult<ResponseModel>> Stop(WorkProcessRouteTimeHistoriesDtoC dto)
        { 
            return await _workProcessRouteTimeHistoriesService.Stop(dto);
        }
        
        [HttpPost(nameof(StopVirtual))]
        public async Task<ActionResult<ResponseModel>> StopVirtual(WorkProcessRouteTimeHistoriesDtoC dto)
        { 
            return await _workProcessRouteTimeHistoriesService.StopVirtual(dto);
        }

    }
}