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
using techiz.Service.Implementation;

namespace techizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductionImportController : ControllerBase
    {
        private readonly IProductionService _productionService;
        private readonly IProductionLogService _productionLogService;
        private readonly IMaterialService _materialService;
        private readonly IWareHouseService _wareHouseService;
        private IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger<ProductionImportController> _logger;

        public ProductionImportController(IProductionService productionService,
            IHttpContextAccessor httpContextAccessor,
            IMaterialService materialService,
            IProductionLogService productionLogService,
            IWareHouseService wareHouseService,
            ILogger<ProductionImportController> logger
        )
        {
            _productionService = productionService;
            _httpContextAccessor = httpContextAccessor;
            _materialService = materialService;
            _wareHouseService = wareHouseService;
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
                foreach (var item in dto.Material.ToList())
                {
                    item.ProductionId = (int)resultProductionInfo.Result.Data;
                    item.WareHouseId = _wareHouseService.GetBynemToId(item.HAMMADDE_YERI).Result;

                    await _materialService.ImportToAdd(item);
                }

                await _productionLogService.Add(new ProductionLogDtoC()
                {
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