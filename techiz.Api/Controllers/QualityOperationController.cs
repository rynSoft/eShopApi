using Microsoft.AspNetCore.Mvc;
using techiz.Service.Contract;
using System.Threading.Tasks;
using techiz.Domain.Common;
using techiz.Domain.Dtos;

namespace techizApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/QualityOperation")]
    public class QualityOperationController : ControllerBase
    {
        private readonly IQualityOperationService _QualityOperationService;

        public QualityOperationController(IQualityOperationService qualityInfoService)
        {
            _QualityOperationService = qualityInfoService;
        }

        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _QualityOperationService.GetAll();

            if (result is not null)
            {

                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _QualityOperationService.GetById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetByLineId))]
        public async Task<IActionResult> GetByLineId(int id)
        {
            var result = await _QualityOperationService.GetByLineId(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(QualityOperationDtoC dto)
        {
            return await _QualityOperationService.Add(dto);
        }

  



        [HttpPost(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(QualityOperationDtoC dto)
        {
            return await _QualityOperationService.Update(dto);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            var result = _QualityOperationService.Delete(Id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");

        }


        [HttpGet(nameof(GetUserOperationList))]
        public async Task<ActionResult<ResponseModel>> GetUserOperationList()
        {
            var result = _QualityOperationService.GetUserOperationList();
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetApprowingUserList))]
        public async Task<ActionResult<ResponseModel>> GetApprowingUserList()
        {
            var result = _QualityOperationService.GetApprowingUserList();
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");
        }
        [HttpGet(nameof(GetUserAutherizationList))]
        public async Task<ActionResult<ResponseModel>> GetUserAutherizationList()
        {
            var result = _QualityOperationService.GetUserAutherizationList();
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");
        }
        [HttpGet(nameof(GetApprowingUserDetail))]
        public async Task<ActionResult<ResponseModel>> GetApprowingUserDetail(int id)
        {
            var result = _QualityOperationService.GetUserApprowingDetail(id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetApprowingUserDetailConfirmation))]
        public async Task<ActionResult<ResponseModel>> GetApprowingUserDetailConfirmation(int id)
        {
            var result = _QualityOperationService.GetUserApprowingDetailConfirmation(id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetUserAutherizationDetail))]
        public async Task<ActionResult<ResponseModel>> GetUserAutherizationDetail(int id)
        {
            var result = _QualityOperationService.GetUserAutherizationDetail(id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(EndProcess))]
        public async Task<ActionResult<ResponseModel>> EndProcess(int id)
        {
            var result = _QualityOperationService.QualityOperationEndProcess(id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");
        }

        [HttpPut(nameof(UpdateConfirmation))]
        public async Task<ActionResult<ResponseModel>> UpdateConfirmation(int id)
        {
            var result = _QualityOperationService.UpdateConfirmation(id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");
        }
        [HttpPost(nameof(StartOperation))]
        public async Task<ActionResult<ResponseModel>> StartOperation(int id)
        {
            return await _QualityOperationService.StartOperation(id);
        }
    }
}