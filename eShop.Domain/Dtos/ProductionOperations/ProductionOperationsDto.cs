using System;
using techiz.Domain.Auth;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class ProductionOperationsDto
{

    public int? Id { get; set; }
    public string QrCode { get; set; }
    public int ProductionId { get; set; }
  

}