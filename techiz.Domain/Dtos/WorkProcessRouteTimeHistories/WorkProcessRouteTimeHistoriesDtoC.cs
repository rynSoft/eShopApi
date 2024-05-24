using System;
using techiz.Domain.Auth;
using techiz.Domain.Entities;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class WorkProcessRouteTimeHistoriesDtoC
{
    public int? WorkProcessRouteId { get; set; }
    public int? RestCauseId { get; set; }
    public int? ProductionId { get; set; }

    public Guid UserId { get; set; }
    public int? ShiftTargetParametersId { get; set; }
    public WorkProcessRouteTimeStatus WorkProcessRouteTimeStatus { get; set; }
    public DateTimeOffset StartDate { get; set; } = DateTime.UtcNow;
    public DateTimeOffset? EndDate { get; set; }
    public TimeSpan ElapsedTime { get; set; }
    public string Definition { get; set; }
}