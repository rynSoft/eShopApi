using System;
using System.Collections.Generic;

namespace eShop.Domain.Dtos
{
    public class RoleDto
    {
        public Guid Id { get; set; }

        public string NormalizedName { get; set; }
    }
}