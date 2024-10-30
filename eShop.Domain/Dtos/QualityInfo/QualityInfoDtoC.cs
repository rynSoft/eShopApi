using System;
using eShop.Domain.Auth;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class QualityInfoDtoC
{
    public int Id { get; set; }
    public int QualityOperationId { get; set; }
    public int QualityId { get; set; }
    public QualityProcessType QualityProcessType { get; set; }
    public string ProductionCode { get; set; }
    public string LotInformation { get; set; }
    public string Description { get; set; }
    public double Piece { get; set; }
}