using System;
using eShop.Domain.Auth;
using eShop.Domain.Entities;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class WorkProcessRouteUserDtoQ
{
    public int? Id { get; set; }
    public int WorkProcessRouteoId { get; set; }
    public Guid? UserId { get; set; }
}