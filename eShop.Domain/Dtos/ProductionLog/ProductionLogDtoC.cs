using System;
using techiz.Domain.Auth;
using techiz.Domain.Entities;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class ProductionLogDtoC
{
    public int ProductionId { get; set; }
    public Guid? UserId { get; set; }
    public int? WorkProcessRouteId { get; set; }
    public DateTimeOffset Date { get; set; } = DateTimeOffset.Now;
    public string Message { get; set; }
}