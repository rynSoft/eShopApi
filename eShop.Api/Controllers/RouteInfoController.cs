using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using techiz.Service.Contract;
using techiz.Domain.Entities;
using System;
using System.Threading.Tasks;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Service.Implementation;

namespace techizApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/RouteInfoUser")]
    public class RouteInfoUserController : ControllerBase
    {
        private readonly IRouteInfoUserService _routeInfoUserService;
        private readonly IProductionUserService _productionUserService;

        public RouteInfoUserController(IRouteInfoUserService routeInfoUserService, IProductionUserService productionUserService)
        {
            _routeInfoUserService = routeInfoUserService;
            _productionUserService = productionUserService;
        }

        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _routeInfoUserService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(GetAllAsyncProductId))]
        public async Task<IActionResult> GetAllAsyncProductId(int id)
        {
            var result = await _routeInfoUserService.GetAllAsyncProductId(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _routeInfoUserService.Get(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }

        
        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(RouteInfoUserDtoC dto)
        { 

            return await _routeInfoUserService.Add(dto);
        }
        
        [HttpPut(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(RouteInfoUserDtoC dto)
        {
            return await _routeInfoUserService.Update(dto);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            var result = _routeInfoUserService.Delete(Id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");

        }

    }
}