using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using eShop.Service.Contract;
using eShop.Domain.Entities;
using System;
using System.Threading.Tasks;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using eShop.Service.Implementation;

namespace eShopApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/WorkProcessRouteUser")]
    public class WorkProcessRouteUserController : ControllerBase
    {
        private readonly IWorkProcessRouteUserService _workProcessRouteUserService;

        public WorkProcessRouteUserController(IWorkProcessRouteUserService workProcessRouteUserService)
        {
            _workProcessRouteUserService = workProcessRouteUserService;
        }

        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _workProcessRouteUserService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(GetAllAsyncProductId))]
        public async Task<IActionResult> GetAllAsyncProductId(int id)
        {
            var result = await _workProcessRouteUserService.GetAllAsyncProductId(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _workProcessRouteUserService.Get(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }

        
        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(WorkProcessRouteUserDtoC dto)
        { 

            return await _workProcessRouteUserService.Add(dto);
        }
        
        [HttpPut(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(WorkProcessRouteUserDtoC dto)
        {
            return await _workProcessRouteUserService.Update(dto);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            var result = _workProcessRouteUserService.Delete(Id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");

        }

    }
}