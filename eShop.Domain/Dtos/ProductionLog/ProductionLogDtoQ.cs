using System;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class ProductionLogDtoQ : BaseSimpleModel
{
    public ProductionLogDtoQ()
    {
    }
    public int Id { get; set; }
    public int ProductionId { get; set; }
    public string UserId { get; set; }
    public string UserAd { get; set; }
    public string UserSoyad { get; set; }
    public ProductionProcess ProductionProcess { get; set; }
    public DateTimeOffset Date { get; set; }
    public string Message { get; set; }
    public DateTimeOffset CreateDate { get; set; }
}