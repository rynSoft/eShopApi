using System;
using eShop.Domain.Entities;

namespace eShop.Domain.Dtos;

public class ShiftTargetParametersDtoQ : BaseSimpleModel
{
    public ShiftTargetParametersDtoQ()
    {
    }

    public int Id { get; set; }
    public double TheoreticalSpeed { get; set; }
    public int NumberOfCard { get; set; }
    public int? TargetCardCount { get; set; }
    public int? TotalProductionCard { get; set; }
    
    public int DelayTime { get; set; }
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset EndDate { get; set; }
    public TimeSpan DifferanceDate => EndDate != null ? EndDate - StartDate : TimeSpan.Zero;
    public int RestCauseId { get; set; }
    public int? ShiftDefinitionId { get; set; }
    public ShiftDefinitionDtoQ ShiftDefinition { get; set; }
    public Guid? UserId { get; set; }

    public int? LineId { get; set; }
}