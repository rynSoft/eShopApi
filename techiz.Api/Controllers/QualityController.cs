using Microsoft.AspNetCore.Mvc;
using techiz.Service.Contract;
using System.Threading.Tasks;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Service.Implementation;

namespace techizApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/Quality")]
    public class QualityController : ControllerBase
    {
        private readonly IQualityService _QualityService;
    
        public QualityController(IQualityService qualityInfoService)
        {
            _QualityService = qualityInfoService;
        }
    
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _QualityService.GetAll();

            if (result is not null)
            {

                return Ok(result);
            }
            return BadRequest("No records found");
        }
    
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _QualityService.GetById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetByLineId))]
        public async Task<IActionResult> GetByLineId(int id)
        {
            var result = await _QualityService.GetByLineId(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(QualityDtoC dto)
        {
            return await _QualityService.Add(dto);
        }

        [HttpPost(nameof(AddOperation))]
        public async Task<ActionResult<ResponseModel>> AddOperation(QualityAndOperationDtoC dto)
        {
            return await _QualityService.QualityAndOperationAdd(dto);
        }

   
        [HttpGet(nameof(GetQualityDetail))]
        public async Task<IActionResult> GetQualityDetail(int id)
        {
            var result =   await _QualityService.GetQualityDetail(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }


        [HttpPut(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(QualityDtoC dto)
        {
            return await _QualityService.Update(dto);
        }

        [HttpPut(nameof(UpdateState))]
        public async Task<ActionResult<ResponseModel>> UpdateState(int Id)
        {
            return await _QualityService.UpdateState(Id);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            var result = _QualityService.Delete(Id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");

        }
    }
}