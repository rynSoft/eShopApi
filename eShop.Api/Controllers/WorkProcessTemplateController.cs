﻿using Microsoft.AspNetCore.Mvc;
using eShop.Service.Contract;
using System.Threading.Tasks;
using eShop.Domain.Common;
using eShop.Domain.Dtos;

namespace eShopApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/WorkProcessTemplate")]
    public class WorkProcessTemplateController : ControllerBase
    {
        private readonly IWorkProcessTemplateService _workProcessTemplateService;
    
        public WorkProcessTemplateController(IWorkProcessTemplateService workProcessTemplateService)
        {
            _workProcessTemplateService = workProcessTemplateService;
        }
    
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _workProcessTemplateService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetAllListProductionId))]
        public async Task<IActionResult> GetAllListProductionId(int productionId)
        {
            var result = await _workProcessTemplateService.GetAllListProductionId(productionId);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetNavListProductionId))]
        public async Task<IActionResult> GetNavListProductionId(int productionId)
        {
            var result = await _workProcessTemplateService.GetNavListProductionId(productionId);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        

        [HttpGet(nameof(GetAllFilter))]
        public async Task<IActionResult> GetAllFilter()
        {
            var result = await _workProcessTemplateService.GetAllFilter();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _workProcessTemplateService.GetById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
    
        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(WorkProcessTemplateDtoC dto)
        { 
            return await _workProcessTemplateService.Add(dto);
        }
        
        [HttpPost(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(WorkProcessTemplateDtoC dto)
        { 
            return await _workProcessTemplateService.Update(dto);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            var result = _workProcessTemplateService.Delete(Id);
            if (result is not null)
            {
                return Ok(result.Result);
            }
            return BadRequest("No records found");

        }
    }
}