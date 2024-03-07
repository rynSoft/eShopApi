namespace techiz.Domain.Dtos;

public class BomKitInfoDtoU 
{
    public int Id { get; set; }
    public int ProductionId { get; set; }
    public int? WareHouseId { get; set; }
    public int ProductionInfoOrderNo { get; set; }
    public string Material { get; set; }
    public string Explanation { get; set; }
    public string PartyNumber { get; set; }
    public double Quantity { get; set; }
    public double? RollerQuantity { get; set; }
    public string Unit { get; set; }
    public string SoureProductPlace { get; set; }
    public string WareHouseName { get; set; }
    public string Description { get; set; }
    public int IsKitProvided { get; set; }
    public int IsKitPreperated { get; set; }
    public bool IsSetupVerification { get; set; }
    public bool IsProductionProcess { get; set; } = false;
    public int? SetNo { get; set; }
}