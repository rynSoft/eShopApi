using System;
using techiz.Domain.Auth;
using techiz.Domain.Enum;

namespace techiz.Domain.Entities;

public class ProductionProcessManualTest : BaseSimpleModel
{
    public ProductionProcessManualTest()
    {  
    }
    public int ProductionId { get; set; }
    public virtual Production Production { get; set; }
    public string QrCode { get; set; }
    
    public ProductionProcess ProductionProcess { get; set; }
 
    public DateTimeOffset TestBeginDate { get; set; }
    public DateTimeOffset? TestEndDate { get; set; }
    public int? TestElapsedTime { get; set; }
    public Guid? TestUserId { get; set; }
    public int? ProductionOperationsId { get; set; }
    public virtual ProductionOperations ProductionOperations { get; set; }
    public virtual User TestUser { get; set; }

}