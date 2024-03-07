using Microsoft.AspNetCore.Mvc;
using techiz.Service.Contract;
using System.Threading.Tasks;
using techiz.Domain.Common;
using techiz.Domain.Dtos;

namespace techizApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/WareHouse")]
    public class WareHouseController : ControllerBase
    {
        private readonly IWareHouseService _wareHouseService;
    
        public WareHouseController(IWareHouseService warwHouseService)
        {
            _wareHouseService = warwHouseService;
        }
    
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _wareHouseService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _wareHouseService.Get(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(WareHouseDtoC dto)
        {
            return await _wareHouseService.Add(dto);

        }
            [HttpPost(nameof(AddNewBarcode))]
            public async Task<ActionResult<ResponseModel>> AddNewBarcode(WareHouseDtoBU dto)
            {
                return await _wareHouseService.AddNewBarcode(dto);
            }

            [HttpPut(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(WareHouseDtoU dto)
        { 
            return await _wareHouseService.Update(dto);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            var result = _wareHouseService.Delete(Id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");

        }
    }
}