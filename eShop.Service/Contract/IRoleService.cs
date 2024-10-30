using System;
using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace techiz.Service.Contract
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
