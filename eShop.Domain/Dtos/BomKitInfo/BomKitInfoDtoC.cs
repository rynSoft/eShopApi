using System;

namespace techiz.Domain.Dtos;

public class BomKitInfoDtoC
{
    public string ACIKLAMA { get; set; }

    public string MALZEME{ get; set; }
    public double MIKTAR { get; set; }
    public string MIKTAR_BIRIM { get; set; }
    public int ProductionId { get; set; }
    public string PARTI_NO { get; set; }
    public string? DEPO { get; set; }
    public string NOT { get; set; }
    public string KAYNAK_STOK_YERI { get; set; } 
    public int? WareHouseId { get; set; }
}