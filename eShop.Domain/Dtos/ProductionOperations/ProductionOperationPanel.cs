using System;
using eShop.Domain.Auth;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class ProductionOperationsDtoQ
{
    public int Id { get; set; }
    public string QrCode { get; set; }
    public int GecenSure { get; set; }
    public int SetupVerificationId { get; set; }
    public int MachineId { get; set; }
    public string FeedlerData { get; set; }
    public DateTimeOffset? OperationDate { get; set; }
    public DateTimeOffset? CreateDate { get; set; }
    public OperationProcess OperationProcess { get; set; } 
}