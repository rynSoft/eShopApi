using System;
using System.Collections.Generic;

namespace eShop.Domain.Dtos
{
    public class OeeDto
    {
        public Guid Id { get; set; }
        public string NormalizedName { get; set; }
        public List<PermissionDto> allPermissions { get; set; }
        public List<PermissionDto> currentPermissions { get; set; }
    }
}