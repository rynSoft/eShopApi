using System;
using System.Collections.Generic;

namespace eShop.Domain.Dtos
{
  public class ProductDtoC
    {
        public int? Id { get; set; }
        public string Qrcode { get; set; }
        public int ProductionId { get; set; }
        public int Order { get; set; }
        public int? NextWPRId { get; set; }
        
    }

}