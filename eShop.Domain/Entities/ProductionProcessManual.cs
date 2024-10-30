using System;
using eShop.Domain.Auth;
using eShop.Domain.Enum;

namespace eShop.Domain.Entities;

public class ProductionProcessManual : BaseSimpleModel
{
    public ProductionProcessManual()
    {  
    }
    public int ProductionId { get; set; }
    public virtual Production Production { get; set; }
    public string QrCode { get; set; }
    
    public ProductionProcess ProductionProcess { get; set; }

    public DateTimeOffset? LabelingBeginDate { get; set; }
    public DateTimeOffset? LabelingEndDate { get; set; }
    public int? LabelingElapsedTime { get; set; }
    public Guid? LabelingUserId { get; set; } 
    public virtual User LabelingUser { get; set; }
    
    public DateTimeOffset? DisplayAssemblyBeginDate { get; set; }
    public DateTimeOffset? DisplayAssemblyEndDate { get; set; }
    public int? DisplayAssemblyElapsedTime { get; set; }
    public string? DisplayAssemblyLotNo { get; set; }
    public Guid? DisplayUserId { get; set; } 
    public virtual User DisplayUser { get; set; }
    
    public DateTimeOffset? ProgrammingBeginDate { get; set; }
    public DateTimeOffset? ProgrammingEndDate { get; set; }
    public int? ProgrammingElapsedTime { get; set; }
    public Guid? ProgrammingUserId { get; set; } 
    public virtual User ProgrammingUser { get; set; }
    
    public DateTimeOffset? DetachFromPanelBeginDate { get; set; }
    public DateTimeOffset? DetachFromPanelEndDate { get; set; }
    public int? DetachFromPanelElapsedTime { get; set; }
    public Guid? DetachFromPanelUserId { get; set; } 
    public virtual User DetachFromPanelUser { get; set; }

}