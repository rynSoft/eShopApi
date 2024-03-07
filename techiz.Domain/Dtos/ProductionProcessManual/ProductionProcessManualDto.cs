using System;

namespace techiz.Domain.Dtos.ProductionProcessManual;

public class ProductionProcessManualDto
{
    public int Id { get; set; }
    public int ProductionId { get; set; }
        public string QrCode { get; set; }
        
        public DateTimeOffset LabelingBeginDate { get; set; }
        public DateTimeOffset LabelingEndDate { get; set; }
        public int LabelingElapsedTime { get; set; }
        public Guid LabelingUserId { get; set; } 
        
        public DateTimeOffset DisplayAssemblyBeginDate { get; set; }
        public DateTimeOffset DisplayAssemblyEndDate { get; set; }
        public int DisplayAssemblyElapsedTime { get; set; }
        public string DisplayAssemblyLotNo { get; set; }
        public Guid DisplayUserId { get; set; } 
        
        public DateTimeOffset ProgrammingBeginDate { get; set; }
        public DateTimeOffset ProgrammingEndDate { get; set; }
        public int ProgrammingElapsedTime { get; set; }
        public Guid ProgrammingUserId { get; set; } 
        
        public DateTimeOffset DetachFromPanelBeginDate { get; set; }
        public DateTimeOffset DetachFromPanelEndDate { get; set; }
        public int DetachFromPanelElapsedTime { get; set; }
        public Guid DetachFromPanelUserId { get; set; } 
}