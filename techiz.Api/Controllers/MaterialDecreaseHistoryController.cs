using Microsoft.AspNetCore.Mvc;
using techiz.Service.Contract;
using System.Threading.Tasks;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Enum;
using techiz.Service.Implementation;
using techiz.Domain.Entities;

namespace techizApi.Controllers
{
    [ApiController]
    [Route("api/MaterialDecreaseHistory")]
    public class MaterialDecreaseHistoryController : ControllerBase
    {
        private readonly IMaterialDecreaseHistoryService _materialDecreaseHistoryService;
        public MaterialDecreaseHistoryController(IMaterialDecreaseHistoryService materialDecreaseHistoryService)
        {
            _materialDecreaseHistoryService = materialDecreaseHistoryService;
          }
    
        [HttpGet(nameof(GetAll))]

        public async Task<IActionResult> GetAll()
        {
            var result = await _materialDecreaseHistoryService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

     
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _materialDecreaseHistoryService.Get(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }

        [HttpGet(nameof(GetProductHistoryId))]
        public async Task<IActionResult> GetProductHistoryId(int productHistoryId)
        {
            var result = await _materialDecreaseHistoryService.GetProductHistoryId(productHistoryId);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }


        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(MaterialDecreaseHistoryDtoC dto)
        { 
            return await _materialDecreaseHistoryService.Add(dto);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            var result = await _materialDecreaseHistoryService.Delete(Id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
    }
}