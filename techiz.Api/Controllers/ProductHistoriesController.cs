using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using techiz.Service.Contract;
using techiz.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.AspNetCore.Http;
using techiz.Domain;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Dtos.ProductionProcessManual;
using techiz.Domain.Enum;
using techiz.Infrastructure;
using techiz.Persistence;
using techiz.Service.Implementation;

namespace techizApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/ProductHistories")]
    public class ProductHistoriesController : ControllerBase
    {
        private readonly IProductHistoriesService _productHistoriesService; 
        private readonly IAppDbContext _appDbContext;
        private IHttpContextAccessor _httpContextAccessor;
        public ProductHistoriesController(IProductHistoriesService productHistoriesService,
            IHttpContextAccessor httpContextAccessor,
            IAppDbContext appDbContext
            )
        {
            _productHistoriesService = productHistoriesService;
            _httpContextAccessor = httpContextAccessor;
            _appDbContext = appDbContext;
        }
    
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productHistoriesService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _productHistoriesService.GetById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(GetAllAsyncProductHistories))]
        public async Task<IActionResult> GetAllAsyncProductHistories(int workProcessRouteId)
        {
            var result = await _productHistoriesService.GetAllAsyncProductHistories(workProcessRouteId);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetByQrCodeHistories))]
        public async Task<IActionResult> GetByQrCodeHistories(int workProcessRouteId,string code)
        {
            var result = await _productHistoriesService.GetByQrCodeHistories(workProcessRouteId,code);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetByQrCodeProduct))]
        public async Task<IActionResult> GetByQrCodeProduct(int productionId,string code)
        {
            var result = await _productHistoriesService.GetByQrCodeProduct(productionId,code );
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(ProductHistoriesDtoC dto)
        {
            return await _productHistoriesService.Add(dto);
        }
        
        [HttpPut(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(ProductionProcessLabelingDto dto)
        {
            return null;
            //return await _productHistoriesService.LabelingUpdate(dto);
        }

    
    }
}