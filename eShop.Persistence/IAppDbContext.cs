using System;
using eShop.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using eShop.Domain.Auth;
using eShop.Domain.Dtos;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.Persistence
{
    public interface IAppDbContext 
    {
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuPermission> MenuPermission { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<IdentityUserClaim<Guid>> UserClaims { get; set; }
        public DbSet<IdentityRoleClaim<Guid>> RoleClaims { get; set; }
        public DbSet<IdentityUserRole<Guid>> UserRole { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<IdentityRole<Guid>> Role { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }
        public DbSet<Production> Production { get; set; }
        public DbSet<Line> Line { get; set; }
        public DbSet<Camera> Camera { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<Material> Material { get; set; }

        Task<int> SaveChangesAsync();
    }
}
