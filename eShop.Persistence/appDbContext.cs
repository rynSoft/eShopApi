using System;
using eShop.Domain.Auth;
using eShop.Domain.Entities;
using eShop.Persistence.Seeds;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eShop.Domain.Enum;
using eShop.Persistence.Mapper;
using Microsoft.AspNetCore.Http;
using eShop.Domain;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace eShop.Persistence
{
    public class appDbContext :  IdentityDbContext<User, IdentityRole<Guid>,Guid> , IAppDbContext
    {
        // This constructor is used of runit testing
        public appDbContext()
        {
        }
        private readonly IHttpContextAccessor _httpContextAccessor;
        public appDbContext(DbContextOptions<appDbContext> options, IHttpContextAccessor httpcontextaccessor) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _httpContextAccessor = httpcontextaccessor;
        }

        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuPermission> MenuPermission { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<IdentityUserClaim<Guid>> UserClaim { get; set; }
        public DbSet<IdentityRoleClaim<Guid>> RoleClaim { get; set; }
        public DbSet<IdentityUserRole<Guid>> UserRole { get; set; }
        public DbSet<IdentityRole<Guid>> Role { get; set; }
        public DbSet<User> User { get; set; }
    
        public DbSet<RefreshToken> RefreshToken { get; set; }

        public DbSet<Material> Material { get; set; }
      

        public DbSet<Product> Product { get; set; }
 
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Identity
            modelBuilder.Entity<IdentityUserToken<Guid>>(x =>
            {
                x.ToTable("UserToken");
                x.HasKey(c => new { c.UserId, c.Value });
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>(x =>
            {
                x.ToTable("UserRole");
                x.HasKey(c => new { c.UserId, c.RoleId });
            });
            modelBuilder.Entity<User>(x =>
            {
                x.ToTable("User");
                x.HasKey(c => c.Id);
            });
            modelBuilder.Entity<IdentityUserLogin<Guid>>(x =>
            {
                x.ToTable("UserLogin");
                x.HasKey(c => new { c.UserId, c.ProviderKey });
            });
            modelBuilder.Entity<IdentityUserClaim<Guid>>(x =>
            {
                x.ToTable("UserClaim");
            });
            modelBuilder.Entity<IdentityRoleClaim<Guid>>(x =>
            {
                x.ToTable("RoleClaim");
            });
            modelBuilder.Entity<IdentityRole<Guid>>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            #endregion

            MenuMapper.Initialize(modelBuilder);
            PermissionMapper.Initialize(modelBuilder);
            MenuPermissionMapper.Initialize(modelBuilder);
            PermissionMapper.Initialize(modelBuilder);
            modelBuilder.Seed();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();

#if DEBUG
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information)
                .EnableDetailedErrors();
#endif
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseNpgsql("User ID=postgres;Password=A192408a#;Server=85.214.12.11;Port=5432;Database=eShop;Pooling=true;", option => {
                option.EnableRetryOnFailure();
                });
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            var user = _httpContextAccessor.HttpContext.GetCurrentGeneralUser();

            var IBaseEntitys = ChangeTracker.Entries().Where(e => e.Entity is IBaseSimpleModel);

            foreach (var entityEntry in IBaseEntitys)
            {
                if (entityEntry.State == EntityState.Added)
                {
                    ((IBaseSimpleModel)entityEntry.Entity).CreateDate = DateTime.Now;
                    ((IBaseSimpleModel)entityEntry.Entity).CreatorId = user;
                }

                if (entityEntry.State == EntityState.Modified)
                {
                    ((IBaseSimpleModel)entityEntry.Entity).EditorId = user;
                    ((IBaseSimpleModel)entityEntry.Entity).EditDate = DateTime.Now;
                }
            }

            return await  base.SaveChangesAsync();
        }
      
    }
}
