using Microsoft.AspNetCore.Identity;
using eShop.Domain.Enum;
using System.Collections.Generic;
using System;

namespace eShop.Persistence.Seeds
{
    public static class MappingUserRole
    {
        public static List<IdentityUserRole<Guid>> IdentityUserRoleList()
        {
            return new List<IdentityUserRole<Guid>>()
            {
                new IdentityUserRole<Guid>
                {
                    RoleId = Constants.SistemAdmin,
                    UserId = Constants.SistemAdminUser
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = Constants.Admin,
                    UserId = Constants.VillaUser
                }
            };
        }
    }
}
