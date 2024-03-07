using System;
using techiz.Domain.Auth;
using techiz.Domain.Entities;
using techiz.Persistence.Seeds;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using techiz.Domain.Enum;
using techiz.Persistence.Mapper;
using Microsoft.AspNetCore.Http;
using techiz.Domain;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting.Server;
using System.Xml;

namespace techiz.Persistence
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
        public DbSet<WareHouse> WareHouse { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Viewsa> Viewsa { get; set; }
        public DbSet<BomKitInfo> BomKitInfo { get; set; }
        public DbSet<Machine> Machine { get; set; }
        public DbSet<SetupVerificationDChange> SetupVerificationDChange { get; set; }
        public DbSet<ProductionOperationsTimeLog> ProductionOperationsTimeLog { get; set; }

        public DbSet<QualityOperationDocument> QualityOperationDocument { get; set; }
        public DbSet<ProductionUser> ProductionUser { get; set; }
        public DbSet<RouteInfoUser> RouteInfoUser { get; set; }
        public DbSet<ProductionMachineMatch> ProductionMachineMatch { get; set; }
        public DbSet<ShiftTargetParameters> ShiftTargetParameters { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }
        public DbSet<Production> Production { get; set; }
        public DbSet<RouteInfo> RouteInfo { get; set; }
        public DbSet<SetupVerificationInfo> SetupVerificationInfo { get; set; }
        public DbSet<SetupVerification> SetupVerification { get; set; }

        public DbSet<Line> Line { get; set; }
        public DbSet<ProductionLog> ProductionLog { get; set; }
        public DbSet<ProductionOperations> ProductionOperations { get; set; }
        public DbSet<ProductionUserRelation> ProductionUserRelation { get; set; }
        public DbSet<RestCause> RestCause { get; set; }
        public DbSet<ShiftDefinition> ShiftDefinition { get; set; }
        public DbSet<ShiftDefinitionProcess> ShiftDefinitionProcess { get; set; }
        public DbSet<ProductionProcessManual> ProductionProcessManual { get; set; }
        public DbSet<ProductionTimeProcess> ProductionTimeProcess { get; set; }
        public DbSet<WorkCentre> WorkCentre { get; set; }
        public DbSet<SetupVerificationDetails> SetupVerificationDetails { get; set; }
        public DbSet<QualityInfo> QualityInfo { get; set; }
        public DbSet<QualityOperation> QualityOperation { get; set; }
        public DbSet<ProductionProcessManualTest> ProductionProcessManualTest { get; set; }
        public DbSet<Quality> Quality { get; set; }
        public DbSet<QualityUser> QualityUser { get; set; }
        public DbSet<NonComplianceCode> NonComplianceCode { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<RouteInfo>()
                .Property(d => d.RouteStatus)
                .HasConversion(new EnumToStringConverter<RouteStatus>());

            modelBuilder.Entity<User>()
                .HasMany(city => city.QualityOperations).WithOne()
                .HasForeignKey(con => con.UserApprovingId);

            modelBuilder.Entity<User>()
                    .HasMany(city => city.QualityOperations).WithOne()
                    .HasForeignKey(con => con.UserLiableId);
            modelBuilder.Entity<User>()
                .HasMany(city => city.QualityOperations).WithOne()
                .HasForeignKey(con => con.AuthorizedPersonId);
          
            modelBuilder
    .Entity<Viewsa>(builder =>
    {
        builder.HasNoKey();
        builder.ToTable("MY_Viewsa");
    });



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
                .UseNpgsql("Host=192.168.11.29;Database=upts;Username=postgres;Password=Oxit2023!;", option => {
                //.UseNpgsql("User ID=postgres;Password=Oxit2023!;Server=217.116.199.183;Port=5433;Database=upts;Integrated Security=true;Pooling=true;", option => {
                   
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
