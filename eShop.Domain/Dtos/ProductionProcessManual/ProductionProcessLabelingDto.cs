using System;

namespace eShop.Domain.Dtos.ProductionProcessManual;

public class ProductionProcessLabelingDto
{
        public int? Id { get; set; }
        public int ProductionId { get; set; }
        public string? QrCode { get; set; }
        public DateTimeOffset? LabelingBeginDate { get; set; }
        public DateTimeOffset? LabelingEndDate { get; set; }
        public Guid? LabelingUserId { get; set; } 
        public int? LabelingElapsedTime { get; set; }
        public string? LabelingUserAd { get; set; }
        public string? LabelingUserSoyad { get; set; }

        public string FullName
        {
                get
                {
                        return LabelingUserAd + " " + LabelingUserSoyad;
                }
        }
}