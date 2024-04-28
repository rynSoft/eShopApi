using System;
using System.Collections.Generic;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos
{
  public class MaterialHistoriesDtoC
    {
        public int? Id { get; set; }
        public int ProductionId { get; set; }
        public int MaterialId { get; set; }
        public int WorkProcessRouteId { get; set; }
        public Guid? UserId { get; set; }
        public string Explination { get; set; }
        public bool? IsFininshed { get; set; }
        public bool? MaterialUsableState { get; set; }
        
        public int? NextProcessRouteId { get; set; }
        public MaterailReadState MaterailReadState { get; set; }
    }

}