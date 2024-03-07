using System;

namespace techiz.Domain.Dtos.ProductionProcessManual;

public class ProductionProcessProgrammingDto
{
        public int? Id { get; set; }
        public int ProductionId { get; set; }
        public string? QrCode { get; set; }
        public DateTimeOffset? ProgrammingBeginDate { get; set; }
        public DateTimeOffset? ProgrammingEndDate { get; set; }
        public int? ProgrammingElapsedTime { get; set; }
        public Guid? ProgrammingUserId { get; set; } 
        public string? ProgrammingUserAd { get; set; }
        public string? ProgrammingUserSoyad { get; set; }

        public string FullName
        {
                get
                {
                        return ProgrammingUserAd + " " + ProgrammingUserSoyad;
                }
        }
}