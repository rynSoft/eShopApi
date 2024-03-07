using System;

namespace techiz.Domain.Dtos;

public class ShiftDefinitionDtoQ : BaseSimpleModel
{
    public ShiftDefinitionDtoQ()
    {
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public bool Active { get; set; }
    public TimeSpan StartDate { get; set; }
    public TimeSpan EndDate { get; set; } 
}