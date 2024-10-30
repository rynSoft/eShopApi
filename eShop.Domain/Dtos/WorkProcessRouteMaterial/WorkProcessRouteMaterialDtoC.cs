using System;
using System.Collections.Generic;
using eShop.Domain.Entities;

namespace eShop.Domain.Dtos
{
  public class WorkProcessRouteMaterialDtoC
    {
        public int? Id { get; set; }
        public int WorkProcessRouteId { get; set; }
        public int MaterialId { get; set; }


    }

}