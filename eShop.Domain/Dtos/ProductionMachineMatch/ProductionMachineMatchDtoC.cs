using System;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class ProductionMachineMatchDtoC
{
    public int? Id { get; set; }
    public int MachineId { get; set; }
    public int ProductionId { get; set; }
}