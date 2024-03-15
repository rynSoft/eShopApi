using System;

namespace techiz.Domain.Dtos
{
    public class UserRouteInfoDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? SurName { get; set; }

        public int? WorkProcessRouteId { get; set; }
    }
}