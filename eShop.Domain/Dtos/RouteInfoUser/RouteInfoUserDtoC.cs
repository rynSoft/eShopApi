using System;

namespace eShop.Domain.Dtos;

public class RouteInfoUserDtoC
{
    public int? Id { get; set; }
    public int? RouteInfoId { get; set; }
    public Guid? UserId { get; set; }
}