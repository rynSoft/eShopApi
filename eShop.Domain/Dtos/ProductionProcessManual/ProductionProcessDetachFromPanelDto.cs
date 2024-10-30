using System;

namespace eShop.Domain.Dtos.ProductionProcessManual;

public class ProductionProcessDetachFromPanelDto
{
        public int? Id { get; set; }
        public int ProductionId { get; set; }
        public string QrCode { get; set; }
        public DateTimeOffset? DetachFromPanelBeginDate { get; set; }
        public DateTimeOffset? DetachFromPanelEndDate { get; set; }
        public int? DetachFromPanelElapsedTime { get; set; }
        public Guid? DetachFromPanelUserId { get; set; } 
        public string? DetachFromPanelUserAd { get; set; }
        public string? DetachFromPanelUserSoyad { get; set; }

        public string FullName
        {
                get
                {
                        return DetachFromPanelUserAd + " " + DetachFromPanelUserSoyad;
                }
        }
}