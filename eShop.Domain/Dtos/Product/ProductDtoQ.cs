using System;
using System.Collections.Generic;
using System.Xml.Linq;
using eShop.Domain.Auth;

namespace eShop.Domain.Dtos
{
  public class ProductDtoQ
    {
        public int Id { get; set; }
        public string UserAdSoyAd { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public string Qrcode { get; set; }
    }
}