using System;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class ProductionMachineMatchDtoU 
{
    public int Id { get; set; }
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset EndDate { get; set; }
    public string QrCode { get; set; }
    public int MachineId { get; set; }
    public int ProductionId { get; set; }
    public int? ElapsedTime { get; set; }
    public bool? State { get; set; }
}