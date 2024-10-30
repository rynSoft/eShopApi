﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using techiz.Domain.Auth;
using System.Collections.Generic;
using techiz.Domain.Entities;

namespace techiz.Persistence.Seeds
{
    public static class ContextSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            CreateRoles(modelBuilder);

            CreateBasicUsers(modelBuilder);

            MapUserRole(modelBuilder);
            
            CreateMenu(modelBuilder);

            CreatePermissions(modelBuilder);
            
            CreateWorkCentre(modelBuilder);
        }

        private static void CreateRoles(ModelBuilder modelBuilder)
        {
            List<IdentityRole> roles = DefaultRoles.IdentityRoleList();
            modelBuilder.Entity<IdentityRole>().HasData(roles);
        }

        private static void CreateBasicUsers(ModelBuilder modelBuilder)
        {
            List<User> users = DefaultUser.IdentityBasicUserList();
            modelBuilder.Entity<User>().HasData(users);
        }

        private static void MapUserRole(ModelBuilder modelBuilder)
        {
            //var identityUserRoles = MappingUserRole.IdentityUserRoleList();
            //modelBuilder.Entity<IdentityUserRole<string>>().HasData(identityUserRoles);
        }

        private static void CreateMenu(ModelBuilder modelBuilder)
        {

            var menu = SeedMenu.MenuList();
            modelBuilder.Entity<Menu>().HasData(menu);
        }

        private static void CreatePermissions(ModelBuilder modelBuilder)
        {
            var permission = SeedPermission.PermissionList();
            modelBuilder.Entity<Permission>().HasData(permission);
        }
        
        private static void CreateWorkCentre(ModelBuilder modelBuilder)
        {
            var workCentre = SeedWorkCentre.WorkCentreList();
            modelBuilder.Entity<WorkCentre>().HasData(workCentre);
        }
    }
}
