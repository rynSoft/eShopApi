using System;
using System.Collections.Generic;

namespace techiz.Domain.Dtos
{
  public class ProductionDtoQ
    {
        public string OrderNo { get; set; }
        public int Quantity { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public string Aciklama { get; set; }
        public string UretimAdi { get; set; }
        public int?  EstimatedTime { get; set; }

        public int? PanelCardCount { get; set; }
    }
    
}