using System;

namespace techiz.Domain.Dtos;

public class ShiftDefinitionProcessDtoC
{
    public int? Id { get; set; }
    public int ShiftDefinitionId { get; set; }   
    public int LineId { get; set; } 
    public Guid? UserId { get; set; }
    public string? Explanation { get; set; }
    public int? TargetQuantity { get; set; }
}