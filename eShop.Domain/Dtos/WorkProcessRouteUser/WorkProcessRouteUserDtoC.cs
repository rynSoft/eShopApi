using System;
using techiz.Domain.Auth;
using techiz.Domain.Entities;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class WorkProcessRouteUserDtoC
{
    public int? WorkProcessRouteId { get; set; }
    public Guid? UserId { get; set; }
}