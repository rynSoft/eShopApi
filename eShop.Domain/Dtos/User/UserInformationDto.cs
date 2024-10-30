using System;

namespace eShop.Domain.Dtos
{
    public class UserInformationDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Status { get; set; }

        public string? Password { get; set; }
        public string? Role { get; set; }
        public Guid? RoleId { get; set; }
        public string? Phone { get; set; }
        public byte[]? Image { get; set; }
    }
}