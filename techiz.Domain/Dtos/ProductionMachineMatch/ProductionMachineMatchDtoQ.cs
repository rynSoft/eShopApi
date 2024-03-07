using System;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class ProductionMachineMatchDtoQ 
{
    public int MachineId { get; set; }
 
    public int ProductionId { get; set; }
 
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset EndDate { get; set; }
    public bool? State { get; set; }
}