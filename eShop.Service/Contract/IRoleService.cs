using System;
using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShop.Service.Contract
{
    public interface IRoleService
    {
        Task<Response<List<RoleDto>>> GetRoles();
        Task<Response<Guid>> RegisterRoleAsync(RoleRequest request);
        Task<Response<Guid>> RoleAssign(string id);
        Task<Response<RolePermissionDto>> GetRoleById(Guid Id);
        Task<Response<List<RoleUsersDto>>> GetUserRoles();
        Task<Response<List<PermissionDto>>> GetPermissions();
        Task<Response<bool>> RoleUpdate(Guid userId, Guid roleId);

    }
}
