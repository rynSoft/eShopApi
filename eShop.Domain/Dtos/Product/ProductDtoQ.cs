using System;
using System.Collections.Generic;
using System.Xml.Linq;
using techiz.Domain.Auth;

namespace techiz.Domain.Dtos
{
  public class ProductDtoQ
    {
        public int Id { get; set; }
        public string UserAdSoyAd { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public string Qrcode { get; set; }
    }
}