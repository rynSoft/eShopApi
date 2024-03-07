
using System;
using techiz.Domain.Auth;
using techiz.Domain.Entities;

namespace techiz.Domain.Dtos;

public class ShiftTargetParametersDtoC
{
    public int? Id { get; set; }
    public double TheoreticalSpeed { get; set; }
    public int NumberOfCard { get; set; }
    public int DelayTime { get; set; }
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset EndDate { get; set; }
    public bool IsFinished { get; set; } = false;
    public TimeSpan DifferanceDate =>  EndDate - StartDate ;
    public int? RestCauseId { get; set; }
    public int? TargetCardCount { get; set; }
    public int ShiftDefinitionId { get; set; }
    public Guid UserId { get; set; }
    public int LineId { get; set; }

}