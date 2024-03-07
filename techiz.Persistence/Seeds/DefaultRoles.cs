using Microsoft.AspNetCore.Identity;
using techiz.Domain.Enum;
using System.Collections.Generic;

namespace techiz.Persistence.Seeds
{

    public static class DefaultRoles
    {
        public static List<IdentityRole> IdentityRoleList()
        {
            return new List<IdentityRole>()
            {
                new IdentityRole
                {
                    Name = Roles.SistemAdmin.ToString().ToLower(),
                    NormalizedName = Roles.SistemAdmin.ToString().ToUpper()
                },
                new IdentityRole
                {
                    Name = Roles.Admin.ToString().ToLower(),
                    NormalizedName = Roles.Admin.ToString().ToUpper()
                },
                new IdentityRole
                {
                    Name = Roles.Depo.ToString().ToLower(),
                    NormalizedName = Roles.Depo.ToString().ToUpper()
                },
            
            };
        }
    }
}
