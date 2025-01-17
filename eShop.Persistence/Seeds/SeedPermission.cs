﻿
using eShop.Domain.Entities;
using eShop.Domain.Utilities;
using System;
using System.Collections.Generic;

namespace eShop.Persistence.Seeds
{
    public static class SeedPermission
    {
        public static List<Permission> PermissionList()
        {
            List<Permission> pL = new List<Permission>();

            for (int i = 1; i <= Permissions.getPermissions().Count; i++)
            {
                pL.Add(new Permission()
                {
                    Id = i,
                    Name = Permissions.getPermissions()[i - 1]
                });
            }
            return pL;
        }
    }
}
