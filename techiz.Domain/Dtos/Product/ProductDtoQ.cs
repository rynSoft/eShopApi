using System;
using System.Collections.Generic;

namespace techiz.Domain.Dtos
{
  public class ProductDtoQ
    {
        public int Id { get; set; }
        public string Operator { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public string Qrcode { get; set; }
    }
}