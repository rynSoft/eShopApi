using System;
using techiz.Domain.Auth;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class ProductionOperationsTimeLogDtoC
{
    public int ProductionId { get; set; }
    public int? ProductionOperationsId { get; set; }
    public int LastTime { get; set; }
    public int CurrentTime { get; set; }
    public string Message { get; set; }
}