using System;
using System.Collections.Generic;
using System.Xml.Linq;
using techiz.Domain.Auth;

namespace techiz.Domain.Dtos
{
  public class WorkProcessRouteMaterialDtoQ
    {
        public int Id { get; set; }
        public int WorkProcessRouteId { get; set; }
        public int MaterialId { get; set; }
    }
}