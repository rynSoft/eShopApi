using System;
using techiz.Domain.Auth;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class SetupVerificationDChangeDtoQ
{
    public DateTimeOffset? CreateDate { get; set; }
    public int ProductionId { get; set; }
    public string OldBomKitCode { get; set; }
    public string NewBomKitCode { get; set; }
    public string OldPanelCode { get; set; }
    public string NewPanelCode { get; set; }
    public double? OldPanelQty { get; set; }

    public double? NewPanelQty { get; set; }
}