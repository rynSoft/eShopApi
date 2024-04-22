using System;
using System.Collections.Generic;
using System.Xml.Linq;
using techiz.Domain.Auth;
using techiz.Domain.Entities;

namespace techiz.Domain.Dtos
{
  public class MaterialDecreaseHistoryDtoQ
    {
        public int? Id { get; set; }
        public int? WorkProcessRouteId { get; set; }
        public int? MaterialId { get; set; }
        public string? Description { get; set; }
        public string? MaterialCode { get; set; }
        public string? MaterialRemainQuantity { get; set; }
        public double? Quantity { get; set; }
    }
}