using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using eShop.Domain.Auth;
using eShop.Service.Contract;
using System.Threading.Tasks;
using System.Transactions;
using AutoMapper;
using Serilog;
using eShop.Domain;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using eShop.Domain.Entities;
using eShop.Persistence;

namespace eShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkCentreController : ControllerBase
    {
        private readonly IWorkCentreService _workCentreService;
        public WorkCentreController(IWorkCentreService workCentreService
        )
        {
            _workCentreService = workCentreService;
        }
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _workCentreService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(WorkCentreDtoC dto)
        { 
            return await _workCentreService.Add(dto);
        }
    }
}