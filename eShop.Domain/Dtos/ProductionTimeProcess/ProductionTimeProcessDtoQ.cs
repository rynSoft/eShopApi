using System;
using eShop.Domain.Auth;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class ProductionTimeProcessDtoQ
{
    public int Id { get; set; }
    public int ProductionId { get; set; }
    //public Guid UserId { get; set; }
    //public string UserAd { get; set; }
    //public string UserSoyad { get; set; }
    public string RestCause { get; set; }
    public string ProductionProcess { get; set; }
    public string ProductionTimeStatus { get; set; }
    
    public DateTimeOffset Date { get; set; }
    public TimeSpan ElapsedTime { get; set; }
    public string Message { get; set; }
}