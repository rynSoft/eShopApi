﻿using Microsoft.AspNetCore.Mvc;
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
    [Route("api/Material")]
    public class MaterialController : ControllerBase
    {
        private readonly IMaterialService _materialService;
        public MaterialController(IMaterialService materialService)
        {
            _materialService = materialService;
          }
    
        [HttpGet(nameof(GetAll))]

        public async Task<IActionResult> GetAll()
        {
            var result = await _materialService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

     
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _materialService.Get(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }

        [HttpGet(nameof(GetAllMaterialId))]
        public async Task<IActionResult> GetAllMaterialId(int productionId)
        {
            var result = await _materialService.GetAllMaterialId(productionId);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }


        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(MaterialDtoC dto)
        { 
            return await _materialService.Add(dto);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            var result = await _materialService.Delete(Id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
    }
}