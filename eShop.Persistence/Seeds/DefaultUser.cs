﻿using eShop.Domain.Auth;
using eShop.Domain.Enum;
using System;
using System.Collections.Generic;

namespace eShop.Persistence.Seeds
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
                    UserName = "eShop",
                    Email = "eShop@sentytech.com",
                    Eposta = "eShop@sentytech.com",
                    Ad = "eShop",
                    Soyad = "eShop",
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
