using System;
using eShop.Domain.Auth;
using eShop.Domain.Entities;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class ProductionLogDtoC
{
    public int ProductionId { get; set; }
    public Guid? UserId { get; set; }
    public int? WorkProcessRouteId { get; set; }
    public DateTimeOffset Date { get; set; } = DateTimeOffset.Now;
    public string Message { get; set; }
}