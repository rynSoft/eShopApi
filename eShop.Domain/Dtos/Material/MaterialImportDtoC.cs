using System;

namespace eShop.Domain.Dtos;

public class MaterialImportDtoC
{
    public int ProductionId { get; set; }
    public int? WareHouseId { get; set; }
    public string URUN_BARKOD_KODU { get; set; }
    public string URUN_KODU { get; set; }
    public string URUN_ADI { get; set; }
    public string PARTI_NO { get; set; }
    public double MIKTAR { get; set; }
    public double DUSUM_MIKTARI { get; set; }
    public string BIRIM { get; set; }
    public string? HAMMADDE_YERI { get; set; }
    public string? ACIKLAMA { get; set; }

}