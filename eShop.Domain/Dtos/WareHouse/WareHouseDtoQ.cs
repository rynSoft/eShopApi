using System;

namespace eShop.Domain.Dtos;

public class WareHouseDtoQ
{
    public int Id { get; set; }
    public string Code  { get; set; }
    public string Name { get; set; }
    public string BarcodeCode { get; set; }
    public string Description { get; set; }
}