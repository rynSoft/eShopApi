using System;
using System.Collections.Generic;
using System.Xml.Linq;
using eShop.Domain.Auth;
using eShop.Domain.Entities;

namespace eShop.Domain.Dtos
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