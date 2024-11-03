using Microsoft.AspNetCore.Identity;
using eShop.Domain.Enum;
using System.Collections.Generic;
using System;

namespace eShop.Persistence.Seeds
{

    public static class DefaultRoles
    {
        public static List<IdentityRole> IdentityRoleList()
        {
            return new List<IdentityRole>()
            {
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = Roles.SistemAdmin.ToString().ToLower(),
                    NormalizedName = Roles.SistemAdmin.ToString().ToUpper()
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = Roles.Admin.ToString().ToLower(),
                    NormalizedName = Roles.Admin.ToString().ToUpper()
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = Roles.Depo.ToString().ToLower(),
                    NormalizedName = Roles.Depo.ToString().ToUpper()
                },
            
            };
        }
    }
}
