using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using eShop.Service.Contract;
using eShop.Domain.Entities;
using System;
using System.Threading.Tasks;
using eShop.Domain.Common;
using eShop.Domain.Dtos;

namespace eShopApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/RouteInfo")]
    public class RouteInfoController : ControllerBase
    {
        private readonly IRouteInfoService _routeInfoService;
    
        public RouteInfoController(IRouteInfoService routeInfoService)
        {
            _routeInfoService = routeInfoService;
        }
    
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _routeInfoService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(GetAllAsyncProductId))]
        public async Task<IActionResult> GetAllAsyncProductId(int id)
        {
            var result = await _routeInfoService.GetAllAsyncProductId(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _routeInfoService.Get(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }

        
        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(RouteInfoDtoC dto)
        { 
            return await _routeInfoService.Add(dto);
        }
        
        [HttpPut(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(RouteInfoDtoC dto)
        {
            return await _routeInfoService.Update(dto);
        }
        [HttpPut(nameof(UpdateState))]
        public async Task<ActionResult<ResponseModel>> UpdateState(RouteInfoDtoC dto)
        {
            return await _routeInfoService.UpdateState(dto);
        }

    }
}