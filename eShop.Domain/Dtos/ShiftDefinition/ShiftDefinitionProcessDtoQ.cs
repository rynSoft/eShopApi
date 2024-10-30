using System;

namespace eShop.Domain.Dtos;

public class ShiftDefinitionProcessDtoQ : BaseSimpleModel
{
    public ShiftDefinitionProcessDtoQ()
    {
    }

    public int? Id { get; set; }
    public int ShiftDefinitionId { get; set; }   
    public int? LineId { get; set; }
    public int? LineNumber { get; set; }
    public string? LineName { get; set; }
    public string? ShiftDefinitionName { get; set; }
    public Guid UserId { get; set; }
    public string? Explanation { get; set; }
    public int? TargetQuantity { get; set; }
}