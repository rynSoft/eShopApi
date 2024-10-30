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
            UserRole = new();
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
        public virtual HashSet<IdentityUserRole<Guid>> UserRole { get; set; }

        
    }
}