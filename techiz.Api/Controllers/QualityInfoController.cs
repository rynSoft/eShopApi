using Microsoft.AspNetCore.Mvc;
using techiz.Service.Contract;
using System.Threading.Tasks;
using techiz.Domain.Common;
using techiz.Domain.Dtos;

namespace techizApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/QualityInfo")]
    public class QualityInfoController : ControllerBase
    {
        private readonly IQualityInfoService _QualityInfoService;
    
        public QualityInfoController(IQualityInfoService qualityInfoService)
        {
            _QualityInfoService = qualityInfoService;
        }
    
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _QualityInfoService.GetAll();

            if (result is not null)
            {

                return Ok(result);
            }
            return BadRequest("No records found");
        }
    
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _QualityInfoService.GetById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetByLineId))]
        public async Task<IActionResult> GetByLineId(int id)
        {
            var result = await _QualityInfoService.GetByLineId(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(QualityInfoDtoC dto)
        { 
            return await _QualityInfoService.Add(dto);
        }
        
        [HttpPost(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(QualityInfoDtoC dto)
        { 
            return await _QualityInfoService.Update(dto);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            var result = _QualityInfoService.Delete(Id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");

        }

        [HttpGet(nameof(GetQualityOperation))]
        public async Task<IActionResult> GetQualityOperation(int id)
        {
            var result = await _QualityInfoService.GetQualityOperation(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetAllQuality))]
        public async Task<IActionResult> GetAllQuality(int id)
        {
            var result = await _QualityInfoService.GetAllQuality(id);

            if (result is not null)
            {

                return Ok(result);
            }
            return BadRequest("No records found");
        }
    }
}