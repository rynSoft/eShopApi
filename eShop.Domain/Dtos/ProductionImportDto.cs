using System;
using System.Collections.Generic;
using eShop.Domain.Dtos;

namespace eShop.Domain;

public class ProductionImportDto
{
    public ProductionDtoC Production { get; set; }
     public HashSet<MaterialImportDtoC> Material { get; set; }
}
