using System;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class ProductDtoC
{
    public int? Id { get; set; }
    public string OrjinalNr { get; set; }
    public string NameTR { get; set; }
    public string NameEn { get; set; }
    public string NameDe { get; set; }
    public string Explanation { get; set; }

    public string Brand { get; set; }
    public string Weight { get; set; }
    public string Length { get; set; }
    public string Width { get; set; }

    public string Height { get; set; }
    public string CustomsNr { get; set; }
    public string BuyingPrice { get; set; }
    public string InvoiceNr { get; set; }
    public string Supplier { get; set; }
}