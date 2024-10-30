using System;
using techiz.Domain.Auth;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

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