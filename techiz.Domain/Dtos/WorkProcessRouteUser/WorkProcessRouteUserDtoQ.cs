using System;
using techiz.Domain.Auth;
using techiz.Domain.Entities;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class WorkProcessRouteUserDtoQ
{
    public int WorkProcessRouteoId { get; set; }
    public Guid? UserId { get; set; }
}