using Microsoft.AspNetCore.Identity;
using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Service.Contract;
using eShop.Service.Exceptions;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.Extensions.Logging;
using eShop.Persistence;
using System.Collections.Generic;
using eShop.Domain.Dtos;
using eShop.Domain.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace eShop.Service.Implementation
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly UserManager<User> _userManager;
        private IAppDbContext _appDbContext;
        private readonly ILogger<RoleService> _logger;
        private readonly IMapper _mapper;

        public RoleService(UserManager<User> userManager, 
                           RoleManager<IdentityRole<Guid>> roleManager,
                           IAppDbContext appDbContext,
                           ILogger<RoleService> logger,
                           IMapper mapper
                           )
        {
            _roleManager = roleManager;
            _userManager = userManager;
            this._appDbContext = appDbContext;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<Response<Guid>> RegisterRoleAsync(RoleRequest request)
        {
            var roles = await _roleManager.FindByNameAsync(request.Name);
            if (roles != null)
            {
                var permissionroles = request.ClaimListId;

                _appDbContext.RoleClaims.RemoveRange(_appDbContext.RoleClaims.Where(x => x.RoleId == roles.Id).ToList());
                foreach (var items in permissionroles)
                {
                        _appDbContext.RoleClaims.Add(new IdentityRoleClaim<Guid>
                        {
                            RoleId = roles.Id,
                            ClaimValue = items,
                            ClaimType = "permission"
                        });
                }
                await _appDbContext.SaveChangesAsync();
                return new Response<Guid>(roles.Id, message: $"Role Updatet.");
            }
            else
            {
                var role = new IdentityRole<Guid>
                {
                    Id = Guid.NewGuid(),
                    Name = request.Name,
                    NormalizedName = request.Name
                };

                var result = await _roleManager.CreateAsync(role);
                if (result.Succeeded)
                {
                    var permissionroles = _appDbContext.Permission.Where(x => request.ClaimListId.Contains(x.Name)).ToList();
                    foreach (var item in permissionroles)
                    {
                        _appDbContext.RoleClaims.Add(new IdentityRoleClaim<Guid>
                        {
                            RoleId = role.Id,
                            ClaimValue = item.Name,
                            ClaimType = "permission"
                        });
                    }
                    //var permissionGuid = _appDbContext.Permission.FirstOrDefault(x => x.Name == "Permissions.Genel.All").Id;
                    //var menus = _appDbContext.Menu.ToList();
                    //foreach (var item in menus)
                    //{
                    //    _appDbContext.MenuPermission.Add(new MenuPermission
                    //    {
                    //        RoleId = role.Id,
                    //        MenuId = item.Id,
                    //        PermissionId = permissionGuid
                    //    });
                    //}
                    await _appDbContext.SaveChangesAsync();

                    return new Response<Guid>(role.Id, message: $"Role Registered.");
                }
                else
                {
                    throw new ApiException($"{result.Errors.ToList()[0].Description}");
                }
            }
        }
        
        public async Task<Response<bool>> RoleUpdate(Guid userId, Guid roleId)
        {
            try
            {
                var userRole = await _appDbContext.UserRole.AsNoTracking().FirstOrDefaultAsync(x => x.UserId == userId);
                if (userRole != null)
                {
                    _appDbContext.UserRole.Remove(userRole);
                    await _appDbContext.SaveChangesAsync();
                }
                    
                _appDbContext.UserRole.Add(new IdentityUserRole<Guid>() { RoleId = roleId, UserId = userId });
                await _appDbContext.SaveChangesAsync();
     
                    
                return new Response<bool>(data: true, message: "");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new Response<bool>(data: false, message: "Hata var ");
            }
        }
        
   

        public async Task<Response<List<RoleUsersDto>>> GetUserRoles()
        {
            var dtoList = new List<RoleUsersDto>();
           
            var roles = _roleManager.Roles.ToList();

            foreach (var item in roles)
            {
                var rolesUserList  = await _userManager.GetUsersInRoleAsync(item.NormalizedName);
                var userList = new List<UserDto>();
                foreach (var itemuser in rolesUserList)
                {  
                    userList.Add(new UserDto() { size = "sm", title =  $"{itemuser.Ad.ToUpper()} {itemuser.Soyad.ToUpper()}" .ToUpper() 
                      //  , img = itemuser.Image 
                    });
                }
                dtoList.Add( new RoleUsersDto { Id = item.Id, title = item.NormalizedName.ToUpper() ,totalUsers = rolesUserList.Count, users = userList } );
            }
            return new Response<List<RoleUsersDto>>(dtoList , message: $"User && Role Assiged.");
        }

        public async Task<Response<RolePermissionDto>> GetRoleById(Guid Id )
        {
            List<PermissionDto> permissionList = new();

            var role = _roleManager.Roles.FirstOrDefault(x=> x.Id == Id);

            var currentPermission = _appDbContext.RoleClaims.Where(x => x.RoleId == Id).Select(x => new PermissionDto()
            {
                title = x.ClaimValue,
                Id = x.Id,
                chosen = true
            }) .ToList();
            
            List<string> currentList = currentPermission.Select(x => x.title).ToList();

            var dontLikePermission = _appDbContext.Permission.Where(x => !currentList.Contains(x.Name))
                .Select(x=> new PermissionDto()
                {
                    title = x.Name,
                    Id = x.Id,
                    chosen = false
                })
                .ToList();

            permissionList.AddRange(currentPermission);
            permissionList.AddRange(dontLikePermission);

            var rolePermissinList = new RolePermissionDto { Id = Id , NormalizedName = role.NormalizedName, 
                                                            currentPermissions = permissionList
            } ;

            return new Response<RolePermissionDto>(rolePermissinList, message: $"User && Role Assiged.");
        }

        public static Guid ToGuid(int value)
        {
            byte[] bytes = new byte[16];
            BitConverter.GetBytes(value).CopyTo(bytes, 0);
            return new Guid(bytes);
        }


        public async Task<Response<List<RoleDto>>> GetRoles()
        {
            var dtoList = new List<RoleDto>();
            var roles = _roleManager.Roles.ToList();

            foreach (var item in roles)
            {
                dtoList.Add(new RoleDto() { Id = item.Id, NormalizedName = item.NormalizedName });
            }

            return new Response<List<RoleDto>>(dtoList, message: $" Get Roles");
        }

        public async Task<Response<Guid>> RoleAssign(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            
            if (!await _userManager.IsInRoleAsync(user, "KARAKOL"))
            {
                _logger.LogInformation("Adding sysadmin to Admin role");
                var userResult = await _userManager.AddToRoleAsync(user, "KARAKOL");
            }

            await _userManager.AddToRoleAsync(user, "KARAKOL");

            return new Response<Guid>(user.Id, message: $"User && Role Assiged.");
        }

        public async Task<Response<List<PermissionDto>>> GetPermissions()
        {   
            List<PermissionDto> permisson =  _appDbContext.Permission
                .Select(x => new PermissionDto()
                {
                    title = x.Name,
                    Id = x.Id,
                    chosen = false
                })
                .ToList();

            return new Response<List<PermissionDto>>(permisson, message: $" Get Permission");

        }

    }
}
