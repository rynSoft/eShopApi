using System;
using System.Collections.Generic;

namespace eShop.Domain.Dtos
{
    public class PermissionDto
    {
        public int Id { get; set; }

        public string title { get; set; }

        public string ClaimValue { get; set; }

        public bool chosen { get; set; }
    }
}