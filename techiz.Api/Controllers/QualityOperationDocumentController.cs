using Microsoft.AspNetCore.Mvc;
using techiz.Service.Contract;
using System.Threading.Tasks;
using techiz.Domain.Common;
using techiz.Domain.Dtos;

namespace techizApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/QualityOperationDocument")]
    public class QualityOperationDocumentController : ControllerBase
    {
        private readonly IQualityOperationDocumentService _QualityOperationDocumentController;
    
        public QualityOperationDocumentController(IQualityOperationDocumentService documentService)
        {
            _QualityOperationDocumentController = documentService;
        }
    
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _QualityOperationDocumentController.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
    
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _QualityOperationDocumentController.GetById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }


        [HttpGet(nameof(GetDocumentList))]
        public async Task<ActionResult<ResponseModel>> GetDocumentList(int id)
        {
            var result = _QualityOperationDocumentController.OperationDocumentList(id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");
        }

        // [HttpPost(nameof(Add))]
        // public IActionResult Add(LineDtoC dto)
        // { 
        //     _LineService.Add(dto);
        //     return Ok("Data inserted");
        // }
        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(QualityOperationDocumentDtoC dto)
        { 
            return await _QualityOperationDocumentController.Add(dto);
        }

        [HttpPost(nameof(AddDocumentList))]
        public async Task<ActionResult<ResponseModel>> AddDocumentList(QualityOperationDocumentDtoC[] dto)
        {
            return await _QualityOperationDocumentController.AddList(dto);
        }

        [HttpPost(nameof(AddDocumentOperation))]
        public async Task<ActionResult<ResponseModel>> AddDocumentOperation(QualityOperationDocumentDtoC[] dto)
        {
            return await _QualityOperationDocumentController.OperationDocument(dto);
        }

        [HttpPost(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(QualityOperationDocumentDtoC dto)
        { 
            return await _QualityOperationDocumentController.Update(dto);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            var result = _QualityOperationDocumentController.Delete(Id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");

        }
    }
}