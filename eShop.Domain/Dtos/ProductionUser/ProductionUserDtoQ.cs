using System;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class ProductionUserDtoQ : BaseSimpleModel
{
    public ProductionUserDtoQ()
    {
    }

    public int ProductionId { get; set; }
    public Guid UserId { get; set; }
    public ProductionProcess ProductionProcess { get; set; }
    public DateTimeOffset Date { get; set; }
    public string Message { get; set; }
    public DateTimeOffset CreateDate { get; set; }
    public bool? OpenState { get; set; }
}