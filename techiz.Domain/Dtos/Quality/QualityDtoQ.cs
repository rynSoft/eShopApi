using System;
using techiz.Domain.Auth;
using techiz.Domain.Entities;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class QualityDtoQ
{
    public int Id { get; set; }
    public bool State { get; set; }
    public string WorkOrderNumber { get; set; }
    public string ProductionCode { get; set; }
    public string SerialCode { get; set; }
    public double Piece { get; set; }
    public bool Active { get; set; }
    public string NonComplianceCode { get; set; }
    public int QualityOperationId { get; set; }
    public int QualityInfoId { get; set; }
    public string QualityType { get; set; }

}