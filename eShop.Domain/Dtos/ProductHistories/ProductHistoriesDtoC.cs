using System;
using System.Collections.Generic;
using eShop.Domain.Auth;
using eShop.Domain.Entities;

namespace eShop.Domain.Dtos
{
  public class ProductHistoriesDtoC
    {
        public int ProductId { get; set; }
        public int WorkProcessRouteId { get; set; }
        public int ProductionId { get; set; }
        public int? Order { get; set; }
        public string ProductQrCode { get; set; }
        public DateTimeOffset? BeginDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public double? ElapsedTime { get; set; }
        public Guid? UserId { get; set; }
        public string Explanation { get; set; }
        public bool? IsFininshed { get; set; }
        public int? NextProcessRouteId { get; set; }
        public List<MaterialDecreaseHistoryDtoC> Metarialds { get; set; }
    }

}