using System;
using techiz.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using techiz.Domain.Auth;
using techiz.Domain.Dtos;
using System.ComponentModel.DataAnnotations.Schema;

namespace techiz.Persistence
{
    public interface IAppDbContext 
    {
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuPermission> MenuPermission { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<IdentityUserClaim<Guid>> UserClaims { get; set; }
        public DbSet<IdentityRoleClaim<Guid>> RoleClaims { get; set; }
        public DbSet<ProductionMachineMatch> ProductionMachineMatch { get; set; }
        public DbSet<IdentityUserRole<Guid>> UserRole { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Viewsa> Viewsa { get; set; }
        public DbSet<IdentityRole<Guid>> Role { get; set; }
        public DbSet<BomKitInfo> BomKitInfo { get; set; }
        public DbSet<WareHouse> WareHouse { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }
        public DbSet<Machine> Machine { get; set; }
        public DbSet<RouteInfoUser> RouteInfoUser { get; set; }
        public DbSet<ShiftDefinition> ShiftDefinition { get; set; }
        public DbSet<ShiftDefinitionProcess> ShiftDefinitionProcess { get; set; }
        public DbSet<SetupVerification> SetupVerification { get; set; }
        public DbSet<Production> Production { get; set; }
        public DbSet<SetupVerificationDChange> SetupVerificationDChange { get; set; }
        public DbSet<SetupVerificationDetails> SetupVerificationDetails { get; set; }
        public DbSet<ShiftTargetParameters> ShiftTargetParameters { get; set; }
        public DbSet<ProductionOperationsTimeLog> ProductionOperationsTimeLog { get; set; }
        public DbSet<RouteInfo> RouteInfo { get; set; }
        public DbSet<ProductionOperations> ProductionOperations { get; set; }
        public DbSet<ProductionProcessManual> ProductionProcessManual { get; set; }
        public DbSet<SetupVerificationInfo> SetupVerificationInfo { get; set; }
        public DbSet<WorkCentre> WorkCentre { get; set; }
        public DbSet<ProductionUser> ProductionUser { get; set; }
        public DbSet<Line> Line { get; set; }
        public DbSet<ProductionLog> ProductionLog { get; set; }
        public DbSet<ProductionProcessManualTest> ProductionProcessManualTest { get; set; }
        public DbSet<ProductionUserRelation> ProductionUserRelation { get; set; }
        public DbSet<RestCause> RestCause { get; set; }
        public DbSet<QualityInfo> QualityInfo { get; set; }
        public DbSet<QualityOperation> QualityOperation { get; set; }
        public DbSet<Quality> Quality { get; set; }
        public DbSet<ProductionTimeProcess> ProductionTimeProcess { get; set; }
        public DbSet<QualityOperationDocument> QualityOperationDocument { get; set; }
        public DbSet<QualityUser> QualityUser { get; set; }
        public DbSet<NonComplianceCode> NonComplianceCode { get; set; }
        public DbSet<WorkProcessRoute> WorkProcessRoute { get; set; }
        public DbSet<WorkProcessRouteUser> WorkProcessRouteUser { get; set; }
        public DbSet<Camera> Camera { get; set; }
        public DbSet<WorkProcessTemplate> WorkProcessTemplate { get; set; }

        public DbSet<Product> Product { get; set; }
        public DbSet<ProductHistories> ProductHistories { get; set; }
        public DbSet<WorkProcessRouteTimeHistories> WorkProcessRouteTimeHistories { get; set; }

        public DbSet<Material> Material { get; set; }
        public DbSet<MaterialHistories> MaterialHistories { get; set; }
        
        public DbSet<MaterialDecreaseHistory> MaterialDecreaseHistory { get; set; }
        public DbSet<WorkProcessRouteMaterial> WorkProcessRouteMaterial { get; set; }
        Task<int> SaveChangesAsync();
    }
}
