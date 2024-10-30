using System;
using eShop.Domain.Auth;
using eShop.Domain.Entities;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class WorkProcessRouteUserDtoC
{
    public int? WorkProcessRouteId { get; set; }
    public Guid? UserId { get; set; }
}