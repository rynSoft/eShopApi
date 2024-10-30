using techiz.Domain.Auth;
using techiz.Domain.Enum;
using System;
using System.Collections.Generic;

namespace techiz.Persistence.Seeds
{
    public static class DefaultUser
    {
        public static List<User> IdentityBasicUserList()
        {
            return new List<User>()
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "hakanyildirim",
                    Email = "hakan@.com",
                    Eposta = "hakan@.com",
                    Ad = "Hakan",
                    Soyad = "YILDIRIM",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    // Password@123
                    PasswordHash = "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==",
                    NormalizedEmail= "SUPERADMIN@GMAIL.COM",
                    NormalizedUserName="SUPERADMIN"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "Tolga",
                    Email = "tolga@.com",
                    Eposta = "tolga@.com",
                    Ad = "Tolga",
                    Soyad = "Bagin",
                    EmailConfirmed = true,
                    
                    PhoneNumberConfirmed = false,
                    // Password@123
                    PasswordHash = "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==",
                    NormalizedEmail= "BASICUSER@GMAIL.COM",
                    NormalizedUserName="BASICUSER"
                },
               new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "Salih",
                    Email = "salih@.com",
                    Eposta = "salih@.com",
                    Ad = "Salih",
                    Soyad = "Dürüs",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = false,
                    // Password@123
                    PasswordHash = "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==",
                    NormalizedEmail= "BASICUSER@GMAIL.COM",
                    NormalizedUserName="SUPERADMIN"
                },
               new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "cagan",
                    Email = "cagan@.com",
                    Eposta = "cagan@.com",
                    Ad = "Cagan",
                    Soyad = "Turhan",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = false,
                    // Password@123
                    PasswordHash = "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==",
                    NormalizedEmail= "BASICUSER@GMAIL.COM",
                    NormalizedUserName="SUPERADMIN"
                },
                   new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "Techiz",
                    Email = "techiz@sentytech.com",
                    Eposta = "techiz@sentytech.com",
                    Ad = "Techiz",
                    Soyad = "Techiz",
                    EmailConfirmed = true,

                    PhoneNumberConfirmed = false,
                    // Password@123
                    PasswordHash = "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==",
                    NormalizedEmail= "BASICUSER@GMAIL.COM",
                    NormalizedUserName="BASICUSER"
                },
            };
        }
    }
}
