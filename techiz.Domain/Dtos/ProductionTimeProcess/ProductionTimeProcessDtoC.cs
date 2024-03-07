using System;
using techiz.Domain.Auth;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class ProductionTimeProcessDtoC
{
    public int ProductionId { get; set; }
    public Guid? UserId { get; set; }
    public int? RestCauseId { get; set; }
    public ProductionProcess ProductionProcess { get; set; }
    public ProductionTimeStatus ProductionTimeStatus { get; set; }
    public int? ShiftTargetParametersId { get; set; }
    public DateTimeOffset Date { get; set; }
    public TimeSpan ElapsedTime { get; set; }
    public string Message { get; set; }
}