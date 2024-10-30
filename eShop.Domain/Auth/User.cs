using System;
using eShop.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace eShop.Domain.Auth
{
    public class User : IdentityUser<Guid>
    {
        public User()
        {
            ProductionProcessManualTest = new();
            ProductionUserRelation = new();
            UserRole = new();
            QualityOperations = new HashSet<QualityOperation>();
            Product = new();
            WorkProcessRoute = new();

        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Eposta { get; set; }
        public string TelefonGSM { get; set; }
        public byte[] Image { get; set; }
        public bool IsActive { get; set; } = true;
        public List<RefreshToken> RefreshTokens { get; set; }
        public bool OwnsToken(string token)
        {
            return this.RefreshTokens?.Find(x => x.Token == token) != null;
        }
        public virtual HashSet<ProductionUserRelation> ProductionUserRelation { get; set; }
         public virtual HashSet<ProductionLog> ProductionLog { get; set; }
         public virtual HashSet<ProductionUser> ProductionUser { get; set; }

        public virtual HashSet<ShiftTargetParameters> ShiftTargetParameters { get; set; }
        public virtual HashSet<ProductionProcessManualTest> ProductionProcessManualTest { get; set; }

        public ICollection<QualityOperation> QualityOperations { get; set; }
        public virtual HashSet<IdentityUserRole<Guid>> UserRole { get; set; }
       public virtual HashSet<Product> Product { get; set; }
        public virtual HashSet<WorkProcessRoute> WorkProcessRoute { get; set; }
        
    }
}