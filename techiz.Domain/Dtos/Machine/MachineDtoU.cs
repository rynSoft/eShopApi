using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class MachineDtoU 
{
    public int Id { get; set; }
    public int LineId { get; set; }
    public string LineAd { get; set; }
        
    public string Code { get; set; }
    public string Name { get; set; }
    public string? BarcodeReaderId { get; set; }
    public int LedNumber { get; set; }
}