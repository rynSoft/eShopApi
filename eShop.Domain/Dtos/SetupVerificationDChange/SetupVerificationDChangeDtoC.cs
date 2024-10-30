using System;
using eShop.Domain.Auth;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class SetupVerificationDChangeDtoC
{
    public int ProductionId { get; set; }
    public int SetupVerificationDetailsOldId { get; set; }
    public int SetupVerificationDetailsNewId { get; set; }
    public int OldPanelId { get; set; }

    public int NewPanelId { get; set; }
    public double? OldPanelQty { get; set; }

    public double? NewPanelQty { get; set; }
}