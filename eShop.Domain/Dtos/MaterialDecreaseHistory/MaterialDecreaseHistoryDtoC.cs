using System;
using System.Collections.Generic;

namespace eShop.Domain.Dtos
{
  public class MaterialDecreaseHistoryDtoC
    {
        public int? Id { get; set; }
        public int? WorkProcessRouteId { get; set; }
        public int? MaterialId { get; set; }
        public int? ProductHistoriesId { get; set; }
        public string? Description { get; set; }
        public double? Quantity { get; set; }

    }

}