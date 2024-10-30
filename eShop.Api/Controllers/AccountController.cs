using System;
using Microsoft.AspNetCore.Mvc;
using techiz.Domain.Auth;
using techiz.Service.Contract;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using Serilog;
using techiz.Domain.Dtos;
using techiz.Domain.Utilities;
using techizApi.Auth;
using Microsoft.AspNetCore.Http;
using techiz.Service;

namespace techizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly IMemoryCache _cache;

        public AccountController(IAccountService accountService,
                                 IMemoryCache cache
                                 )
        {
          
            _accountService = accountService;
            _cache = cache;
        }
        
        [HttpPost("authenticate")]
        public async Task<IActionResult> AuthenticateAsync(AuthenticationRequest request)
        {
            return Ok(await _accountService.AuthenticateAsync(request, GenerateIPAddress()));
        }

        [HttpGet("TokenSessionControl")]
        public async Task<IActionResult> TokenSessionControl()
        {       
            return Ok(await _accountService.TokenSessionControl());
        }

        [HttpPost("register"),YetkiDenetimi(Permissions.Kullanici.Kaydet)]
        public async Task<IActionResult> RegisterAsync(RegisterRequest request)
        {
            var origin = Request.Headers["origin"];
            return Ok(await _accountService.RegisterAsync(request, origin));
        }
        
          
        [HttpPut("{id}"),  YetkiDenetimi(Permissions.Kullanici.Kaydet)]
        public async Task<ActionResult<bool>> PutUser(UserInformationDto? dto)
        {
            var result = await _accountService.PutUser(dto);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        

        [HttpGet("confirm-email")]
        public async Task<IActionResult> ConfirmEmailAsync([FromQuery] string userId, [FromQuery] string code)
        {
            var origin = Request.Headers["origin"];
            return Ok(await _accountService.ConfirmEmailAsync(userId, code));
        }
       
        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequest model)
        {
            await _accountService.ForgotPassword(model, Request.Headers["origin"]);
            return Ok();
        }
      
        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest model)
        {

            return Ok(await _accountService.ResetPassword(model));
        }
        [HttpGet(nameof(GetAllAsync))]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _accountService.GetAllAsync();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(GetAllTaskAsync))]
        public async Task<IActionResult> GetAllTaskAsync(Guid Id)
        {
            var result = await _accountService.GetAllTaskAsync(Id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        
        [HttpGet(nameof(UpdateTaskAsync))]
        public async Task<IActionResult> UpdateTaskAsync(int Id)
        {
            var result = await _accountService.UpdateTaskAsync(Id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetAllTaskQualityAsync))]
        public async Task<IActionResult> GetAllTaskQualityAsync(Guid Id)
        {
            var result = await _accountService.GetAllTaskQualityAsync(Id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(UpdateTaskQualityAsync))]
        public async Task<IActionResult> UpdateTaskQualityAsync(int Id)
        {
            var result = await _accountService.UpdateTaskQualityAsync(Id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpPost("logout")]
        public async Task<ActionResult<bool>> Logout()
        {
            _cache.Remove("usertokens");
            _cache.Remove("permissionsCache");

            return Ok(true);
        }
        
        [HttpDelete("{id}"),  YetkiDenetimi(Permissions.Kullanici.Sil)]
        public async Task<ActionResult<bool>> Delete(Guid id)
        {
            var result = await _accountService.Delete(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

      
        private string GenerateIPAddress()
        {
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
                return Request.Headers["X-Forwarded-For"];
            else
                return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        }
    }
}