using Microsoft.AspNetCore.Mvc;
using eShop.Service.Contract;
using System.Threading.Tasks;
using eShop.Domain.Common;
using eShop.Domain.Dtos;

namespace eShopApi.Controllers
{
    //[Authorize]
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
            var result = await _productService.GetById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
    
        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(ProductDtoC dto)
        { 
            return await _productService.Add(dto);
        }
        
        [HttpPost(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(ProductDtoC dto)
        { 
            return await _productService.Update(dto);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            var result = _productService.Delete(Id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");

        }
    }
}