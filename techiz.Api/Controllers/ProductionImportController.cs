using System;
using Microsoft.AspNetCore.Mvc;
using techiz.Service.Contract;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using techiz.Domain;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Enum;
using techiz.Infrastructure;
using System.Threading;
using System.Linq;

namespace techizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductionImportController : ControllerBase
    {
        private readonly IProductionService _productionService;
        private  IRouteInfoService _routeInfoService;
        private IRouteInfoUserService _routeInfoUserService;
        private  IBomKitInfoService _bomKitInfoService;
        private readonly IProductionLogService _productionLogService;
        private readonly IProductionUserService _productionUserService;
        private readonly IWareHouseService _wareHouseService;
        private IHttpContextAccessor _httpContextAccessor;
        private  IWorkCentreService _workCentreService;
        private readonly ILogger<ProductionImportController> _logger;
        public ProductionImportController(IProductionService productionService,
            IRouteInfoService routeInfoService,
            IBomKitInfoService bomKitInfoService,
            IWareHouseService wareHouseService,
            IHttpContextAccessor httpContextAccessor,
            IWorkCentreService workCentreService,
            IRouteInfoUserService routeInfoUserService,
            IProductionUserService productionUserService,
            IProductionLogService productionLogService,
            ILogger<ProductionImportController> logger
        )
        {
            _routeInfoUserService = routeInfoUserService;
            _productionService = productionService;
            _productionUserService = productionUserService;
            _routeInfoService = routeInfoService;
            _wareHouseService = wareHouseService;
            _bomKitInfoService = bomKitInfoService;
            _httpContextAccessor = httpContextAccessor;
            _workCentreService = workCentreService;
            _productionLogService = productionLogService;
            _logger = logger;
        }

        [HttpPost(nameof(ImportProduction))]
        public async Task<ActionResult<ResponseModel>> ImportProduction(ProductionImportDto dto)
        {
            var productionId = 0;
            using (TransactionScope ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                var user = _httpContextAccessor.HttpContext.GetCurrentUser();
                dto.Production.CreatorId = user;
                var resultProductionInfo = _productionService.Add(dto.Production);
                productionId = (int)resultProductionInfo.Result.Data;
                Console.WriteLine("Basladı" + DateTime.Now.ToLongTimeString());

                _logger.LogError("Writing to log");
                foreach (var item in dto.BomKit.ToList())
                {
                    item.DEPO = item.KAYNAK_STOK_YERI;
                    item.ProductionId = (int)resultProductionInfo.Result.Data;
                    item.WareHouseId = _wareHouseService.GetBynemToId(item.KAYNAK_STOK_YERI).Result;


                    await _bomKitInfoService.Add(item);
                }
              
                int iOrder = 0;
                foreach (var item in dto.Route)
                {
                    item.State = false;
                    item.Order = 0;
                    switch (item.ACIKLAMA.Trim())
                    {
                        case "KIT_HAZIRLAMA":
                            iOrder++;
                            item.ProductionProcess = ProductionProcess.KitProvision;
                            item.State = true;
                            item.Order = iOrder;
                            break;
                        case "DOKUMAN_KONTROLU":
                            iOrder++;
                            item.ProductionProcess = ProductionProcess.KitVerification;
                            item.State = true;
                            item.Order = iOrder;
                            break;
                        case "SETUP_DOGRULAMA":
                            iOrder++;
                            item.ProductionProcess = ProductionProcess.SetupVerification;
                            item.State = true;
                            item.Order = iOrder;
                            break;
                        case "DIZGI":
                            iOrder++;
                            item.ProductionProcess = ProductionProcess.ProductionProcess;
                            item.State = true;
                            item.Order = iOrder;
                            break;
                        case "ETIKETLEME":
                            iOrder++;
                            item.ProductionProcess = ProductionProcess.ProductionProcessLabeling;
                            item.State = true;
                            item.Order = iOrder;
                            break;
                        case "DISPLAY":
                            iOrder++;
                            item.ProductionProcess = ProductionProcess.ProductionProcessDisplayAssembly;
                            item.State = true;
                            item.Order = iOrder;
                            break;
                        case "PROGRAMLAMA":
                            iOrder++;
                            item.ProductionProcess = ProductionProcess.ProductionProcessProgramming;
                            item.State = true;
                            item.Order = iOrder;
                            break;
                        case "PANELDEN_AYIRMA":
                            iOrder++;
                            item.ProductionProcess = ProductionProcess.ProductionProcessDetachFromPanel;
                            item.State = true;
                            item.Order = iOrder;
                            break;
                        case "TEST":
                            iOrder++;
                            item.ProductionProcess = ProductionProcess.ProductionProcessTest;
                            item.State = true;
                            item.Order = iOrder;
                            break;
                    }

                   
                    item.ACIKLAMA = item.ACIKLAMA.Trim();
                    if (item.ACIKLAMA == "KIT_HAZIRLAMA")
                    {
                        item.UserId = dto.Production.UserId;
                        item.WorkCentreId = 2;

                        item.ProductionId = (int)resultProductionInfo.Result.Data;
                        var result = _routeInfoService.Add(item).Result.Data;
                        int routeInfoId = Int32.Parse(result.ToString());

                        RouteInfoUserDtoC routeInfoUserDtoC = new RouteInfoUserDtoC();
                        routeInfoUserDtoC.UserId = dto.Production.UserId;
                        routeInfoUserDtoC.RouteInfoId = routeInfoId;
                        await _routeInfoUserService.Add(routeInfoUserDtoC);
                    }
                    else
                    {
                        item.WorkCentreId = 2;
                        item.ProductionId = (int)resultProductionInfo.Result.Data;
                        await _routeInfoService.Add(item);

                    }
                }

                await _productionLogService.Add(new ProductionLogDtoC()
                {
                    ProductionProcess = ProductionProcess.Created,
                    Date = DateTimeOffset.Now,
                    ProductionId = (int)resultProductionInfo.Result.Data,
                    Message = $"Üretim İş Emri Oluşturuldu. {dto.Production.orderNo}",
                    UserId = user
                });

                Console.WriteLine("Bitti" + DateTime.Now.ToLongTimeString());

                ts.Complete();
            }

            ResponseModel rm = new() {Success = true, Data = productionId};
            return new ActionResult<ResponseModel>(rm);
        }
    }
}