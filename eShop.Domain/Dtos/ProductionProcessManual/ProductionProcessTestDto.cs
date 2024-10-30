using System;

namespace eShop.Domain.Dtos.ProductionProcessManual;

public class ProductionProcessTestDto
{
        public int? Id { get; set; }
        public int ProductionId { get; set; }
       
        public string QrCode { get; set; }
       public int? RangeCount { get; set; }
    public DateTimeOffset? TestBeginDate { get; set; }
        public DateTimeOffset? TestEndDate { get; set; }
        public int? TestElapsedTime { get; set; }
        public Guid TestUserId { get; set; } 
        public string? TestUserAd { get; set; }
        public string? TestUserSoyad { get; set; }
        public string? ProductionOperationsQrCode { get; set; }

    public string FullName
        {
                get
                {
                        return TestUserAd + " " + TestUserSoyad;
                }
        }
}