using System;
using eShop.Domain.Auth;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class ProductionOperationsDto
{

    public int? Id { get; set; }
    public string QrCode { get; set; }
    public int ProductionId { get; set; }
  

}