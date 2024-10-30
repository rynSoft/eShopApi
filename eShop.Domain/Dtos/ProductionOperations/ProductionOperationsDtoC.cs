using System;
using System.Collections.Generic;
using eShop.Domain.Auth;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class ProductionOperationsDtoC
{
    public int? Id { get; set; }
    public string QrCode { get; set; }
    public int ProductionId { get; set; }
    public int GecenSure { get; set; }

    public int MachineId { get; set; }
    public int SetupVerificationId { get; set; }
    public string FeedlerData { get; set; }
    public DateTimeOffset? OperationDate { get; set; }
    public int? ShiftTargetParametersId { get; set; }
    public OperationProcess OperationProcess { get; set; } 
}