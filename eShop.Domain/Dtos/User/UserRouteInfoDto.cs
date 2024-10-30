using System;

namespace eShop.Domain.Dtos
{
    public class UserRouteInfoDto
    {
        public Guid Id { get; set; }
        public int WorkProcessRouteUserId { get; set; }
        public string? Name { get; set; }
        public string? SurName { get; set; }

        public int? WorkProcessRouteId { get; set; }
    }
}