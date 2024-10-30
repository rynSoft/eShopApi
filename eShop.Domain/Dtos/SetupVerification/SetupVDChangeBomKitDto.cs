using System;
using System.Collections.Generic;
using techiz.Domain.Dtos;

namespace techiz.Domain;

public class SetupVDChangeBomKitDto
{
    public int? ProductionId { get; set; }
    public int? Id { get; set; }
    public int NewBomKitId { get; set; }
    public int MachineId { get; set; }
    public string? PartyNumber { get; set; }

    public double? UsingQuantity { get; set; }
    public double? RollerQuantity { get; set; }
    public double? FinishingQuantity { get; set; }
}

