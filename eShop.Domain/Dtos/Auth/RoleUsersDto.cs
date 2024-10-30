using System;
using System.Collections.Generic;

namespace eShop.Domain.Dtos
{
    public class RoleUsersDto
    {
        public Guid Id { get; set; }
        public string title { get; set; }

        public int totalUsers { get; set; }
        public List<UserDto> users { get; set; }
    }
}