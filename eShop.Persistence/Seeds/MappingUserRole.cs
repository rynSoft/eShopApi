using Microsoft.AspNetCore.Identity;
using techiz.Domain.Enum;
using System.Collections.Generic;

namespace techiz.Persistence.Seeds
{
    public static class MappingUserRole
    {
        public static List<IdentityUserRole<string>> IdentityUserRoleList()
        {
            return new List<IdentityUserRole<string>>()
            {
                new IdentityUserRole<string>
                {
                    RoleId = Constants.SistemAdmin,
                    UserId = Constants.SistemAdminUser
                },
                new IdentityUserRole<string>
                {
                    RoleId = Constants.Admin,
                    UserId = Constants.VillaUser
                }
            };
        }
    }
}
