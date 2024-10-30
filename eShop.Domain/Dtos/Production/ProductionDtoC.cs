using System;
using System.Collections.Generic;

namespace techiz.Domain.Dtos
{
  public class ProductionDtoC 
    {
        public int? Id { get; set; }
        public string orderNo { get; set; }
        public int quantity { get; set; }
        public string aciklama { get; set; }
        public string uretimAdi { get; set; }
        public Guid? UserId { get; set; }
        public Guid? CreatorId { get; set; }
        public DateTimeOffset startDate { get; set; }
    }
    
}