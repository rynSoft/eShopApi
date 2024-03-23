using Microsoft.AspNetCore.Mvc;
using techiz.Service.Contract;
using System.Threading.Tasks;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Enum;
using techiz.Service.Implementation;

namespace techizApi.Controllers
{
    [ApiController]
    [Route("api/Product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
          }
    
        [HttpGet(nameof(GetAll))]

        public async Task<IActionResult> GetAll()
        {
            var result = await _productService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

     
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _productService.Get(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }

        [HttpGet(nameof(GetAllProductId))]
        public async Task<IActionResult> GetAllProductId(int id)
        {
            var result = await _productService.GetAllProductId(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }


        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(ProductDtoC dto)
        { 
            return await _productService.Add(dto);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            var result = await _productService.Delete(Id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
    }
}