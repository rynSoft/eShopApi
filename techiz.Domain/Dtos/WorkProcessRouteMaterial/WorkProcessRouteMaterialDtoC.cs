using System;
using System.Collections.Generic;
using techiz.Domain.Entities;

namespace techiz.Domain.Dtos
{
  public class WorkProcessRouteMaterialDtoC
    {
        public int? Id { get; set; }
        public int WorkProcessRouteId { get; set; }
        public int MaterialId { get; set; }


    }

}