using System;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class RouteInfoUserDtoQ
{
    public int Id { get; set; }
    public int? RouteInfoId { get; set; }
    public Guid? UserId { get; set; }
    public string RouteInfoExplanation { get; set; }
    public string UserAd { get; set; }
 
}