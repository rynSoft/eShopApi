using System;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class ProductionMachineMatchDtoQ 
{
    public int MachineId { get; set; }
 
    public int ProductionId { get; set; }
 
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset EndDate { get; set; }
    public bool? State { get; set; }
}