using System;
using techiz.Domain.Auth;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class ProductionUserDtoC
{
    public int ProductionId { get; set; }
    public Guid? UserId { get; set; }
    public ProductionProcess ProductionProcess { get; set; }
    public DateTimeOffset Date { get; set; }
    public string Message { get; set; }
    public bool? OpenState { get; set; }
}