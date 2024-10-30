using System;

namespace techiz.Domain.Dtos;

public class MachineProductsDtoQ 
{
    public int Id { get; set; }
    public int ProductionId { get; set; }
    public int? WareHouseId { get; set; }
    public string WareHouseCode { get; set; }
    public string Material { get; set; }
    public string Explanation { get; set; }
    public string PartyNumber { get; set; }
    public int Quantity { get; set; }
    public string Unit { get; set; }
    public string Description { get; set; }
    public bool IsKitProvided { get; set; }
    public bool IsKitPreperated { get; set; }
    public bool IsSetupVerification { get; set; }
    public string SoureProductPlace { get; set; }
}