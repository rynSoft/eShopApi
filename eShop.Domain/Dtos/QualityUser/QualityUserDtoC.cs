using System;
using eShop.Domain.Auth;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class QualityUserDtoC
{
    public int QualityId { get; set; }
    public Guid? UserId { get; set; }
    public QualityProcess QualityProcess { get; set; }
    public DateTimeOffset Date { get; set; }
    public string Message { get; set; }
    public bool? OpenState { get; set; }
}