using System;
using System.Collections.Generic;

namespace techiz.Domain.Dtos
{
  public class MaterialHistoriesDtoC
    {
        public int? Id { get; set; }
        public int MaterialId { get; set; }
        public int WorkProcessRouteId { get; set; }
        public DateTimeOffset? BeginDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public double? ElapsedTime { get; set; }
        public Guid? UserId { get; set; }
        public string Explination { get; set; }
        public bool? IsFininshed { get; set; }
        public int? NextProcessRouteId { get; set; }
    }

}