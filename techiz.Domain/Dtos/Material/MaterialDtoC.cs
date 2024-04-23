using System;
using System.Collections.Generic;

namespace techiz.Domain.Dtos
{
  public class MaterialDtoC
    {
        public int? Id { get; set; }
        public int ProductionId { get; set; }
        public int? WareHouseId { get; set; }
        public string? Code { get; set; }
        public string Name { get; set; }
        public string? Explanation { get; set; }
        public string? Description { get; set; }
        public string PartyNumber { get; set; }
        public double? Quantity { get; set; }
        public double? RemainQuantity { get; set; }
        public double? DecreaseQuantity { get; set; }
        public string Unit { get; set; }
        public int? NextWPRId { get; set; }

    }

}