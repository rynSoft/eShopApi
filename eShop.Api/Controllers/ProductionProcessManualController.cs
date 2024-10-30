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
    [Route("api/ProductionProcessManual")]
    public class ProductionProcessManualController : ControllerBase
    {
        private readonly IProductionProcessManualService _productionProcessManualService; 
        private readonly IAppDbContext _appDbContext;
        private IHttpContextAccessor _httpContextAccessor;
    
        public ProductionProcessManualController(IProductionProcessManualService productionProcessManualService,
            IHttpContextAccessor httpContextAccessor,
            IAppDbContext appDbContext
            )
        {
            _productionProcessManualService = productionProcessManualService;
            _httpContextAccessor = httpContextAccessor;
            _appDbContext = appDbContext;
        }
    
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productionProcessManualService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _productionProcessManualService.GetById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(GetAllAsyncProductionProcessManualId))]
        public async Task<IActionResult> GetAllAsyncProductionProcessManualId(int id, ProductionProcess process , ProductionProcess previousProcess)
        {
            var result = await _productionProcessManualService.GetAllAsyncProductionProcessManualId(id,process, previousProcess);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetByQrCode))]
        public async Task<IActionResult> GetByQrCode(string code,int productionId, ProductionProcess process, ProductionProcess previousProcess)
        {
            var result = await _productionProcessManualService.GetByQrCode(code.Trim(),productionId, process, previousProcess);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(ProductionManualProcessDto dto)
        {
            return null;
            // var state = new ResponseModel(null);
            // if (dto.QrCode != "Finish24061994")
            // {
            //     state = await _productionProcessManualService.GetByQrCode(dto.QrCode.Trim(), dto.ProductionId, ProductionProcess.ProductionProcessLabeling);
            //
            //     if (state.Data == null)
            //         return new ResponseModel(Success: false, Message: "Okutulan Kod seçili üretim hattında kullanılmamıştır...");
            // }

            // await _productionProcessManualService.ElapsedTimeCalculate(ProductionProcess.ProductionProcessLabeling,dto.ProductionId,null);
            // if (dto.QrCode != "Finish24061994")
            // {
            //     return await _productionProcessManualService.Add(dto);
            // }
            // else
            // {
            //     return new ResponseModel(Success:true,Message:"Finish Edildi");
            // }
        }
        
        [HttpPut(nameof(LabelingUpdate))]
        public async Task<ActionResult<ResponseModel>> LabelingUpdate(ProductionProcessLabelingDto dto)
        {
            return await _productionProcessManualService.LabelingUpdate(dto);
        }

        [HttpPut(nameof(DisplayAssemblyUpdate))]
        public async Task<ActionResult<ResponseModel>> DisplayAssemblyUpdate(ProductionProcessDisplayAssemblyDto dto)
        {
            return await _productionProcessManualService.DisplayAssemblyUpdate(dto);
        }
        
        [HttpPut(nameof(ProgrammingUpdate))]
        public async Task<ActionResult<ResponseModel>> ProgrammingUpdate(ProductionProcessProgrammingDto dto)
        { 
             return await _productionProcessManualService.ProgrammingUpdate(dto);
        }
        
        [HttpPut(nameof(DetachFromPanelUpdate))]
        public async Task<ActionResult<ResponseModel>> DetachFromPanelUpdate(ProductionProcessDetachFromPanelDto dto)
        { 
            return await _productionProcessManualService.DetachFromPanelUpdate(dto);
        }
    }
}