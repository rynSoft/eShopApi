using System;
using eShop.Domain.Auth;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class ProductionOperationsTimeLogDtoQ
{
    public int ProductionId { get; set; }
    public string ProductionOperationsQrCode { get; set; }
    public int ProductionOperationsId { get; set; }
    public int LastTime { get; set; }
    public int CurrentTime { get; set; }
    public string Message { get; set; }
}