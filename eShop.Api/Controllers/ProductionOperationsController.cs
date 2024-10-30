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

namespace eShopApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/ProductionOperations")]
    public class ProductionOperationsController : ControllerBase
    {
        private readonly IProductionOperationsService _productionOperationsService;
        private readonly ISetupVerificationService _setupVerificationService;
        private readonly IProductionProcessManualService _productionManualService;
        private readonly ISetupVerificationDetailService _setupVerificationDetailService;
        private readonly IAppDbContext _appDbContext;
        private IHttpContextAccessor _httpContextAccessor;
    
        public ProductionOperationsController(IProductionOperationsService productionOperationService,
            IHttpContextAccessor httpContextAccessor,
            IAppDbContext appDbContext,
            ISetupVerificationService setupVerificationService,
            ISetupVerificationDetailService setupVerificationDetailService
            , IProductionProcessManualService productionManualService)
        {
            _productionOperationsService = productionOperationService;
            _setupVerificationService = setupVerificationService;
            _httpContextAccessor = httpContextAccessor;
            _appDbContext = appDbContext;
            _setupVerificationDetailService = setupVerificationDetailService;
            _productionManualService = productionManualService;
        }
    
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productionOperationsService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(GetAllAsyncProductionId))]
        public async Task<IActionResult> GetAllAsyncProductionId(int id)
        {
            var result = await _productionOperationsService.GetAllAsyncProductId(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetAllAsyncProductionMachineAndProduction))]
        public async Task<IActionResult> GetAllAsyncProductionMachineAndProduction(int productionId,int machineId)
        {
            var result = await _productionOperationsService.GetAllProductionAndMachne(productionId, machineId);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }


        [HttpGet(nameof(GetAllProductionTimeDetail))]
        public async Task<IActionResult> GetAllProductionTimeDetail(int productionId)
        {
            var result = await _productionOperationsService.GetAllProductionTimeDetail(productionId);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetAllProductionTimeDetailMachine))]
        public async Task<IActionResult> GetAllProductionTimeDetailMachine(int productionId, int machineId)
        {
            var result = await _productionOperationsService.GetAllProductionTimeDetailMachine(productionId, machineId);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetAllAsyncStateProductionId))]
        public async Task<IActionResult> GetAllAsyncStateProductionId(int id,int machineId)
        {
            var result = await _setupVerificationDetailService.GetAllAsyncStateProductionId(id,machineId);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetFilterAsyncProductionId))]
        public async Task<IActionResult> GetFilterAsyncProductionId(int id,string? Code)
        {
            var result = await _productionOperationsService.GetFilterAsyncProductId(id,Code);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetAllQrCodeDetail))]
        public async Task<IActionResult> GetAllQrCodeDetail(string code,int productionId,int machineId)
        {
            var result = await _productionOperationsService.GetAllQrCodeDetail(code, productionId,machineId);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetProductions))]
        public async Task<IActionResult> GetProductions(string materialandLotNo)
        {
            var result = await _productionOperationsService.GetProductions(materialandLotNo);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetMaterialtoQrcode))]
        public async Task<IActionResult> GetMaterialtoQrcode(string materialandLotNo,int productionId)
        {
            var result = await _productionOperationsService.GetMaterialtoQrcode(materialandLotNo, productionId);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(ProductionOperationsDtoC dto)
        {
            // var qrCode = dto.QrCode;
            // var state = await _productionOperationsService.Add(dto);
            // if (!state.Success == false)
            //    return await _setupVerificationDetailService.CalcUsingQuantity(dto.ProductionId,qrCode);
            // else
            //     return new ResponseModel(){ Success = false, Message = "Hata"};
            var qrCode = dto.QrCode;
            var state = await _productionOperationsService.Add(dto);
            if (state.Success)
            { 
                await _productionManualService.Add(new ProductionManualProcessDto(){ QrCode = dto.QrCode , ProductionId = dto.ProductionId});
                return await _setupVerificationDetailService.CalcUsingQuantity(dto.ProductionId,qrCode);
            }
            else
                return new ResponseModel(){ Success = false, Message = "Hata"};
        }
        
        [HttpPost(nameof(ChangeBomKitData))]
        public async Task<ActionResult<ResponseModel>> ChangeBomKitData(SetupVDChangeBomKitDto dto)
        {
            return await _productionOperationsService.ChangeBomKitData(dto);
        }
        
        [HttpGet(nameof(GetSetupVerificationDChange))]
        public async Task<IActionResult> GetSetupVerificationDChange(int productionId,int machineId)
        {
            var result = await _productionOperationsService.GetSetupVerificationDChange(productionId, machineId);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(GetProductionTimeLog))]
        public async Task<IActionResult> GetProductionTimeLog(int productionId)
        {
            var result = await _productionOperationsService.GetProductionTimeLog(productionId);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        
    }
}