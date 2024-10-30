using System;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class RouteInfoDtoC
{
    public int? Id { get; set; }
    public string ACIKLAMA{ get; set; }

    public  string IS_MERKEZI { get; set; }

    public string MALZEME { get; set; }

    public int OPERASYON { get; set; }
    public int? WorkCentreId { get; set; }  
    public int? ProductionId { get; set; }
    public Guid? UserId { get; set; }
    public int? Order { get; set; }
    public bool? State { get; set; }

    public ProductionProcess? ProductionProcess { get; set; }

    // public int ProductionInfoId { get; set; }
    // public string Operation { get; set; }
    // public string Product { get; set; }
    public string Explanation { get; set; }
    // public int WorkCentreId { get; set; }  
}