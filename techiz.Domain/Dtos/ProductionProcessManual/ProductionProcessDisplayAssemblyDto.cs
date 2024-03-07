using System;

namespace techiz.Domain.Dtos.ProductionProcessManual;

public class ProductionProcessDisplayAssemblyDto
{
        public int? Id { get; set; }
        public int ProductionId { get; set; }
        public string QrCode { get; set; }
        public DateTimeOffset? DisplayAssemblyBeginDate { get; set; }
        public DateTimeOffset? DisplayAssemblyEndDate { get; set; }
        public int? DisplayAssemblyElapsedTime { get; set; }
        public string DisplayAssemblyLotNo { get; set; }
        public Guid? DisplayUserId { get; set; } 
        public string? DisplayUserAd { get; set; }
        public string? DisplayUserSoyad { get; set; }

        public string FullName
        {
                get
                {
                        return DisplayUserAd + " " + DisplayUserSoyad;
                }
        }
}