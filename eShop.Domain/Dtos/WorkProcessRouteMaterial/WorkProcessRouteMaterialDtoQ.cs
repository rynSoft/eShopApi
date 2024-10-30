using System;
using System.Collections.Generic;
using System.Xml.Linq;
using eShop.Domain.Auth;

namespace eShop.Domain.Dtos
{
  public class WorkProcessRouteMaterialDtoQ
    {
        public int Id { get; set; }
        public int WorkProcessRouteId { get; set; }
        public int MaterialId { get; set; }
    }
}