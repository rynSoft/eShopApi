
using System;

namespace eShop.Domain.Dtos;

public class ShiftDefinitionDtoC
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public bool Active { get; set; }
    public TimeSpan StartDate { get; set; }
    public TimeSpan EndDate { get; set; }
}