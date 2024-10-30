using System;
using System.Collections.Generic;
using techiz.Domain.Dtos;

namespace techiz.Domain;

public class ProductionImportDto
{
    public ProductionDtoC Production { get; set; }
     public HashSet<MaterialImportDtoC> Material { get; set; }
}
