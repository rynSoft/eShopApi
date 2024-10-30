using System;
using System.Collections.Generic;
using System.Xml.Linq;
using eShop.Domain.Auth;
using eShop.Domain.Entities;

namespace eShop.Domain.Dtos
{
  public class MaterialHistoriesDtoQ
    {
        public int? Id { get; set; }
        public int MaterialId { get; set; }
        public int WorkProcessRouteId { get; set; }
        public DateTimeOffset? BeginDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public double? ElapsedTime { get; set; }
        public Guid? UserId { get; set; }
        public string Explanation { get; set; }
        public bool? IsFininshed { get; set; }
    }
}