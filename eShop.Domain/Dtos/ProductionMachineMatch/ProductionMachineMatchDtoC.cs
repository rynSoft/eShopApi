using System;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class ProductionMachineMatchDtoC
{
    public int? Id { get; set; }
    public int MachineId { get; set; }
    public int ProductionId { get; set; }
}