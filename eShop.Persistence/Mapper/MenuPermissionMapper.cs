﻿
using techiz.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace techiz.Persistence.Mapper
{
    class MenuPermissionMapper
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuPermission>(x =>
            {
                x.HasOne(c => c.Permission).WithMany(c => c.MenuPermission).HasForeignKey(t => t.PermissionId).HasConstraintName("FK_MenuPermission");
                x.HasOne(c => c.Menu).WithMany(c => c.MenuPermission).HasForeignKey(t => t.MenuId).HasConstraintName("FK_Menu");
            });
        }
    }
}
