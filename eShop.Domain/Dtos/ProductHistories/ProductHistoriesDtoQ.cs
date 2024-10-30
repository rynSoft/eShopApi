using System;
using System.Collections.Generic;
using System.Xml.Linq;
using techiz.Domain.Auth;

namespace techiz.Domain.Dtos
{
  public class ProductHistoriesDtoQ
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int WorkProcessRouteId { get; set; }
        public DateTimeOffset? BeginDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public double? ElapsedTime { get; set; }
        public Guid? UserId { get; set; }
        public string Explanation { get; set; }
        public string ProductQrCode { get; set; }
        public bool? IsFininshed { get; set; }
    }
}