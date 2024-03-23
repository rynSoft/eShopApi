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
using System.Reflection.PortableExecutable;

namespace techizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompozingImportController : ControllerBase
    {
        private readonly IProductionLogService _productionLogService;
        private readonly IBomKitInfoService _bomKitInfoService;
        private readonly IAppDbContext _appDbContext;
        private readonly IMapper _mapper;
        private IHttpContextAccessor _httpContextAccessor;

        private readonly ILogger<ProductionImportController> _logger;
        public CompozingImportController(
            IBomKitInfoService bomKitInfoService,
            IAppDbContext appDbContext,
            IMapper mapper,
            IHttpContextAccessor httpContextAccessor,
            IProductionUserService productionUserService,
            IProductionLogService productionLogService,
            ILogger<ProductionImportController> logger
        )
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _bomKitInfoService = bomKitInfoService;
            _productionLogService = productionLogService;
            _logger = logger;
        }

        [HttpPost(nameof(CompozingImport))]
        public async Task<ActionResult<ResponseModel>> CompozingImport(SetupVerificationImportDto dto)
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                var user = _httpContextAccessor.HttpContext.GetCurrentUser();
                Console.WriteLine("Basladı"+ DateTime.Now.ToLongTimeString()  );
                
                    _logger.LogError("Writing to log");
                    foreach (var item in dto.SetupVerification)
                    {
                        SetupVerificationInfo st = new()
                        {
                            ProductionId = dto.ProductionId,
                            SetNo = item.SET_NO,
                            CreatorId = user,
                            Barcode = item.PARTS_NAME,
                            MachineId = dto.MachineId,
                            Decrease=item.DECREASE,
                            RollerQuantity = item.ROLLER_QUANTITY,
                            FileName=dto.FileName,
                            JobName=dto.jobName,
                            IsCompleted=false,
                        }; 
                      
                        await _appDbContext.SetupVerificationInfo.AddAsync(st);
                        await _appDbContext.SaveChangesAsync();
                    } 
                   
                    await _productionLogService.Add(new ProductionLogDtoC()
                    {
                        //ProductionProcess = ProductionProcess.Created,
                        Date = DateTimeOffset.Now,
                        ProductionId = (int) dto.ProductionId,
                        Message = $"Setup Verification Dosyası aktarıldı . Dosya Adı : {dto.FileName }",
                        UserId = user
                    });
                    Console.WriteLine("Bitti"+ DateTime.Now.ToLongTimeString()  );
            
                ts.Complete();
            }
            return new ActionResult<ResponseModel>(new OkResult());
        }
        
        [HttpGet(nameof(GetAllAsyncProductId))]
        public async Task<IActionResult> GetAllAsyncProductId(int id)
        {
            var result = await _appDbContext.SetupVerificationInfo.Include(x=>x.Machine).ThenInclude(x=>x.Line).Include(x => x.BomKitInfo).Where(x=> x.ProductionId == id)
                .Select(x=> new 
                {
                    Id = x.Id,
                    SetNo = x.SetNo, 
                    LineId=x.Machine.LineId,
                    LineName=x.Machine.Line.Name,
                    Barcode = x.Barcode,
                    MachineId = x.MachineId,
                    MachineName=x.Machine.Name,
                    IsVerificated = x.IsVerificated,
                    RollerQuantity = x.RollerQuantity,
                    Decrease=x.Decrease,
                    JobName=x.JobName,
                    BomKitInfo=x.BomKitInfo,
                    IsCompleted = x.IsCompleted
                }).OrderBy(x=>x.Id).ToListAsync();
           
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpPut(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(int Id,int rollerQuantity,int bomKitId,int setNo)
        {
            var data = _appDbContext.SetupVerificationInfo.Where(x => x.Id == Id).FirstOrDefault();
            BomKitInfo bomKitInfo= _appDbContext.BomKitInfo.Where(x => x.Id == bomKitId).FirstOrDefault();
            if (data is not null)
            {
                data.BomKitInfo = bomKitInfo;
                data.IsVerificated = true;
                data.RollerQuantity = rollerQuantity;
                _appDbContext.SetupVerificationInfo.Update(data);
                await _appDbContext.SaveChangesAsync();

                bomKitInfo.SetNo = 5;
                bomKitInfo.IsSetupVerification = true;
                bomKitInfo.RollerQuantity = rollerQuantity;
                await _appDbContext.SaveChangesAsync();
                ResponseModel rm = new() {Success = true};
                return rm;
            }
            ResponseModel rms = new() {Success = false};
            return rms;
        }
    }
}