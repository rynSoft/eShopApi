using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using eShop.Service.Contract;
using eShop.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.AspNetCore.Http;
using eShop.Domain;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using eShop.Domain.Dtos.ProductionProcessManual;
using eShop.Domain.Enum;
using eShop.Infrastructure;
using eShop.Persistence;
using eShop.Service.Implementation;

namespace eShopApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/MaterialHistories")]
    public class MaterialHistoriesController : ControllerBase
    {
        private readonly IMaterialHistoriesService _materialHistoriesService; 
        private readonly IAppDbContext _appDbContext;
        private IHttpContextAccessor _httpContextAccessor;
        public MaterialHistoriesController(IMaterialHistoriesService materialHistoriesService,
            IHttpContextAccessor httpContextAccessor,
            IAppDbContext appDbContext
            )
        {
            _materialHistoriesService = materialHistoriesService;
            _httpContextAccessor = httpContextAccessor;
            _appDbContext = appDbContext;
        }
    
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _materialHistoriesService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _materialHistoriesService.GetById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(GetAllMaterialHistories))]
        public async Task<IActionResult> GetAllMaterialHistories(int productionId,int workProcessRouteId)
        {
            var result = await _materialHistoriesService.GetAllMaterialHistories(productionId,workProcessRouteId);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetByCodeHistories))]
        public async Task<IActionResult> GetByCodeHistories(int workProcessRouteId,string code)
        {
            var result = await _materialHistoriesService.GetByCodeHistories(workProcessRouteId,code);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(MaterialHistoriesDtoC dto)
        {
            return await _materialHistoriesService.Add(dto);
        }
       
    
    }
}