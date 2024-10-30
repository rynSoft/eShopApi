using System;
using System.Collections.Generic;

namespace eShop.Domain.Dtos
{
  public class ProductionQrcodeReportDtoC
    {

        public int ProductionId { get; set; }
        public string Qrcode { get; set; }
        public string Material { get; set; }
        public string PartyNumber { get; set; }
        public string UserInfo { get; set; }
        public DateTimeOffset CreateDate { get; set; }


    }
    
}