using Microsoft.AspNetCore.Mvc;
using eShop.Service.Contract;
using System.Threading.Tasks;
using Serilog;
using eShop.Domain.Auth;
using eShop.Domain.Utilities;
using System;
using eShopApi.Auth;

namespace eShopApi.Controllers
{
    [ApiController]
    [Route("api/Role")]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        
        [HttpGet("getRoles"),YetkiDenetimi(Permissions.Role.Goruntule)]
        public async Task<IActionResult> GetRoles()
        {
            return Ok(await _roleService.GetRoles());
        }

        [HttpGet("GetRoleById"),YetkiDenetimi(Permissions.Role.Goruntule)]
        public async Task<IActionResult> GetRoleById(Guid Id )
        {
            return Ok(await _roleService.GetRoleById(Id));
        }

        [HttpPost("rolRegister"),YetkiDenetimi(Permissions.Role.Kaydet)]
        public async Task<IActionResult> RegisterRoleAsync(RoleRequest request)
        {

            return Ok(await _roleService.RegisterRoleAsync(request));
        }

        [HttpPost("userRoleAssign"),YetkiDenetimi(Permissions.Role.Kaydet)]
        public async Task<IActionResult> RoleAssign(string id)
        {
            return Ok(await _roleService.RoleAssign(id));
        }
        
        [HttpPost("RoleUpdate"),YetkiDenetimi(Permissions.Role.Kaydet)]
        public async Task<IActionResult> RoleUpdate(Guid userId, Guid roleId)
        {
            return Ok(await _roleService.RoleUpdate(userId,roleId));
        }

        [HttpGet("roleWithUser"),YetkiDenetimi(Permissions.Role.Goruntule)]
        public async Task<IActionResult> GetUserRoles()
        {
            return Ok(await _roleService.GetUserRoles());
        }

        [HttpGet("getPermissions"),YetkiDenetimi(Permissions.Role.Goruntule)]
        public async Task<IActionResult> getPermissions()
        {
            return Ok(await _roleService.GetPermissions());
            
        }
    }
}