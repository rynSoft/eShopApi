using System;
using eShop.Domain.Auth;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class ProductionOperationsTimeLogDtoC
{
    public int ProductionId { get; set; }
    public int? ProductionOperationsId { get; set; }
    public int LastTime { get; set; }
    public int CurrentTime { get; set; }
    public string Message { get; set; }
}