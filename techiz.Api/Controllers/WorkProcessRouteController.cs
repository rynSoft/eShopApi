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
    [Route("api/WorkProcessRoute")]
    public class WorkProcessRouteController : ControllerBase
    {
        private readonly IWorkProcessRouteService _workProcessRouteService;
    
        public WorkProcessRouteController(IWorkProcessRouteService workProcessRouteService)
        {
            _workProcessRouteService = workProcessRouteService;
        }
    
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _workProcessRouteService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(GetAllAsyncProductId))]
        public async Task<IActionResult> GetAllAsyncProductId(int id)
        {
            var result = await _workProcessRouteService.GetAllAsyncProductId(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _workProcessRouteService.Get(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }

        
        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(WorkProcessRouteDtoC dto)
        { 
            return await _workProcessRouteService.Add(dto);
        }
        
        [HttpPut(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(WorkProcessRouteDtoC dto)
        {
            return await _workProcessRouteService.Update(dto);
        }
        [HttpPut(nameof(UpdateState))]
        public async Task<ActionResult<ResponseModel>> UpdateState(WorkProcessRouteDtoC dto)
        {
            return await _workProcessRouteService.UpdateState(dto);
        }

    }
}