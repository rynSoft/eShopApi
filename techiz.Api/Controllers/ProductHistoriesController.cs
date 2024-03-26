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
        public async Task<IActionResult> GetAllAsyncProductHistories(int workProcessRouteId, int productionId, int isProductPage)
        {
            var result = await _productHistoriesService.GetAllAsyncProductHistories(workProcessRouteId, productionId, isProductPage);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetByQrCode))]
        public async Task<IActionResult> GetByQrCode(string code, int workProcessRouteId, int productionId)
        {
            var result = await _productHistoriesService.GetByQrCode(code.Trim(), workProcessRouteId, productionId);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(ProductHistoriesDtoC dto)
        {
            //var state = new ResponseModel(null);
            //if (dto.QrCode != "Finish24061994")
            //{
            //    state = await _productHistoriesService.GetByQrCode(dto.QrCode.Trim(), dto.ProductionId, ProductionProcess.ProductionProcessLabeling);

            //    if (state.Data == null)
            //        return new ResponseModel(Success: false, Message: "Okutulan Kod seçili üretim hattında kullanılmamıştır...");
            //}

            return null; 
            //await _productHistoriesService.ElapsedTimeCalculate(dto.WorkProcessRouteId);
           
        }
        
        [HttpPut(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(ProductionProcessLabelingDto dto)
        {
            return null;
            //return await _productHistoriesService.LabelingUpdate(dto);
        }

    
    }
}