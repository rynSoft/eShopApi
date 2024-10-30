using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using techiz.Service.Contract;
using System.Threading.Tasks;
using System.Transactions;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using techiz.Domain;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Entities;
using techiz.Domain.Enum;
using techiz.Infrastructure;
using techiz.Persistence;
using ProductionProcess = techiz.Domain.Enum.ProductionProcess;
using techiz.Service.Implementation;

namespace techizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetupVerificationController : ControllerBase
    {
        private readonly IProductionLogService _productionLogService;
        private readonly IProductionMachineMatchService _productionMachineMatchService;
        private readonly ISetupVerificationService _setupVerificationService;

        private readonly ISetupVerificationDetailService _setupVerificationDetailService;
        private readonly IAppDbContext _appDbContext;
        private readonly IMapper _mapper;
        private readonly IProductionUserService _productionUserService;
        private IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger<SetupVerificationController> _logger;
        
        public SetupVerificationController(
            IBomKitInfoService bomKitInfoService,
            IAppDbContext appDbContext,
            IProductionMachineMatchService productionMachineMatchService,
            ISetupVerificationService setupVerificationService,
            ISetupVerificationDetailService setupVerificationDetailService,
            IMapper mapper,
            IProductionUserService productionUserService,
            IHttpContextAccessor httpContextAccessor,
            IProductionLogService productionLogService,
            ILogger<SetupVerificationController> logger
        )
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
            _productionMachineMatchService = productionMachineMatchService;
            _productionUserService = productionUserService;
            _setupVerificationService = setupVerificationService;
            _httpContextAccessor = httpContextAccessor;
            _setupVerificationDetailService = setupVerificationDetailService;
            _productionLogService = productionLogService;
            _logger = logger;
        }

        [HttpPost(nameof(SetupVerificationCompleted))]
        public async Task<ActionResult<ResponseModel>> SetupVerificationCompleted(SetupVerificationDto dto)
        {
            var setupVerificationId = 0;
  
            using (TransactionScope ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                var user = _httpContextAccessor.HttpContext.GetCurrentUser();
                dto.CreatorId = user;
                dto.Active = true;
             

                var resultSetupVerificationId =  _setupVerificationService.Add(dto);
                setupVerificationId = (int)resultSetupVerificationId.Result.Data;
                Console.WriteLine("Basladı"+ DateTime.Now.ToLongTimeString()  );

                List<SetupVerificationInfo> setupVerficationList = _appDbContext.SetupVerificationInfo.Include(x=>x.BomKitInfo).Where(x => x.MachineId == dto.MachineId && x.ProductionId == dto.ProductionId && x.BomKitInfo!=null).ToList();
                foreach (var setup in setupVerficationList)
                {
                    setup.IsCompleted = true;
                    _appDbContext.SetupVerificationInfo.Update(setup);
                    await _appDbContext.SaveChangesAsync();

                }
                _logger.LogError("Writing to log");
                int machineId = 0; 
                foreach (var setupInfo in setupVerficationList)
                    {
                     machineId = setupInfo.MachineId;  
                    await _setupVerificationDetailService.Add(new SetupVerificationDetailDto()
                    {
                        MachineId   = setupInfo.MachineId,
                        IsCompleted = false,
                        BomKitInfoId = setupInfo.BomKitInfo.Id,
                        SetNo = setupInfo.SetNo,
                        State = true,
                        Quantity = setupInfo.BomKitInfo.Quantity,
                        RollerQuantity = setupInfo.RollerQuantity,
                        Material = setupInfo.BomKitInfo.Material,
                        PartyNumber = setupInfo.BomKitInfo.PartyNumber,
                        SiraNo = 1,
                        SetupVerificationId = setupVerificationId
                    });
                }
                
                 
               //var productionKey= _appDbContext.ProductionUser.Where(x => x.ProductionId == dto.ProductionId && 
               //                                                           x.ProductionProcess == ProductionProcess.ProductionProcess).FirstOrDefault();
               // if (productionKey is null)
               // {
               //     // // gorev atanacak persnel takibi için 
               //     //await _productionUserService.Add(new ProductionUserDtoC()
               //     //{
               //     //    ProductionProcess = ProductionProcess.ProductionProcess,
               //     //    Date = DateTimeOffset.Now,
               //     //    ProductionId = dto.ProductionId,
               //     //    Message = $"Yeni Görev Atandı . Üretim Numarası {dto.ProductionId}",
               //     //    UserId = user
               //     //});
               //     //
               // }

                await _productionLogService.Add(new ProductionLogDtoC()
                    {
                        //ProductionProcess = ProductionProcess.ProductionProcess,
                        Date = DateTimeOffset.Now,
                        ProductionId = (int)dto.ProductionId,
                        Message = $"Üretim Süreci Başlatıldı. {dto.ProductionId}  MachineId {dto.MachineId}",
                        UserId = user
                    });
            
                await _productionMachineMatchService.Add(new ProductionMachineMatchDtoC()
                {
                    ProductionId = (int)dto.ProductionId,
                    MachineId = machineId
                 
                });
                
                ts.Complete();
            }

            ResponseModel rm = new() {Success = true, Data = setupVerificationId};
            return new ActionResult<ResponseModel>(rm);
        }
        
        [HttpGet(nameof(GetAllAsyncProductId))]
        public async Task<IActionResult> GetAllAsyncProductId(int id)
        {
            var result = await _appDbContext.SetupVerificationInfo.Where(x=> x.ProductionId == id)
                .Select(x=> new 
                {
                    Id = x.Id,
                    SetNo = x.SetNo, 
                    Barcode = x.Barcode,
                    IsVerificated = x.IsVerificated,
                    MachineId = x.MachineId,
                }).OrderBy(x=>x.Id).ToListAsync();
           
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(GetMaterialCodeWithBomKit))]
        public async Task<IActionResult> GetMaterialCodeWithBomKit(string materialCode, int productionId,int setNo,int machineId)
        {
            var result = await _setupVerificationDetailService.GetMaterialCodeWithBomKit(materialCode,productionId,setNo,machineId);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }
        
        [HttpGet(nameof(YetAddedSetNoOnFeedler))]
        public async Task<IActionResult> YetAddedSetNoOnFeedler(int productionId,string materialCode)
        {
            var result = await _setupVerificationDetailService.YetAddedSetNoOnFeedler(productionId,materialCode);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }
        
        [HttpGet(nameof(GetAllAsyncProductMachineItem))]
        public async Task<IActionResult> GetAllAsyncProductMachineItem(int id)
        { 
            var activeMachineList =  _appDbContext.ProductionMachineMatch.Where(x => x.ProductionId == id && x.State == true).Select(t=>t.MachineId).ToList();
            var result = await _appDbContext.SetupVerificationDetails.Include(x=> x.SetupVerification).
    
                Where(x=> x.SetupVerification.ProductionId == id && x.State==true && activeMachineList.Contains((int)x.MachineId))
                .Select(x=> new 
                {
                    Id = x.Id,
                    SetupVerificationId = x.SetupVerification.Id,
                    MachineId = x.SetupVerification.MachineId,
                    ProductionMachineMatch = _appDbContext.ProductionMachineMatch.Where(d=>  d.ProductionId == id ).Select
                    (x=> new
                    {
                        ProductionMachineMatchId=x.Id,
                        StartDate=x.StartDate,
                        State=x.State,
                        GecenSure=x.ElapsedTime,
                        EndDate=x.EndDate

                    }).ToList(),
                    BomKitInfoId = x.BomKitInfoId,
                    JobName= _appDbContext.SetupVerificationInfo.Where(y => y.ProductionId == id && y.SetNo == x.SetNo && y.MachineId == x.MachineId).FirstOrDefault().JobName,
                    Decrease = _appDbContext.SetupVerificationInfo.Where(y => y.ProductionId== id && y.SetNo == x.SetNo && y.MachineId== x.MachineId).FirstOrDefault().Decrease,
                    SetNo =x.SetNo,
                    SiraNo = x.SiraNo,
                    Material = x.Material,
                    PartNumber = x.PartyNumber,
                    Quantity = _appDbContext.BomKitInfo.Where(z=> z.Id == x.BomKitInfoId).FirstOrDefault().Quantity, 
                    RollerQuantity = x.RollerQuantity,
                    UsingQuantity = x.UsingQuantity,
                    
                    ChangingBomKitInfoId = x.ChangingBomKitInfoId,
                    // UsingQuantity  = _appDbContext.SetupVerificationDetails.Where(z=> z.BomKitInfoId == x.BomKitInfoId
                    //              && z.SetupVerificationId==x.SetupVerificationId).FirstOrDefault(),
                }
                ).OrderBy(x=> (x.RollerQuantity - x.UsingQuantity)).ToListAsync();
           
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }



        [HttpGet(nameof(GetAllProductionMachineDetailList))]
        public async Task<IActionResult> GetAllProductionMachineDetailList(int id)
        {
            var result = await _appDbContext.SetupVerification.Include(x => x.Machine).
                Where(x => x.ProductionId == id)
                .Select(x => new
                {            
                    Id=x.Id,
                    SetupVerificationId = x.Id,
                    MachineId = x.MachineId,
                    ProductionMachineMatchId = _appDbContext.ProductionMachineMatch.Where(d=> d.MachineId == x.MachineId && d.ProductionId == id ).FirstOrDefault().Id,
                    LineId= x.Machine.LineId,
                    MachineName =x.Machine.Name,         
                    JobName = _appDbContext.SetupVerificationInfo.Where(y => y.ProductionId == id && y.MachineId == x.MachineId).FirstOrDefault().JobName,
                }
                ).ToListAsync();

            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpPut(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(int Id)
        {
            var data = _appDbContext.SetupVerificationInfo.Where(x => x.Id == Id).FirstOrDefault();
            if (data is not null)
            {
                data.IsVerificated = true;
                _appDbContext.SetupVerificationInfo.Update(data);
                await _appDbContext.SaveChangesAsync();
             
                ResponseModel rm = new() {Success = true};
                return rm;
            }
            ResponseModel rms = new() {Success = false};
            return rms;
        }
        
       
    }
}