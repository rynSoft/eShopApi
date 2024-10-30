using System;
using System.Collections.Generic;
using eShop.Domain.Auth;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class RouteInfoDtoQ
{
    public int Id { get; set; }
    public string Explanation { get; set; }
    public Guid? UserId { get; set; }
    public List<UserRouteInfoDto> userList { get; set; }
    public string AdSoyad { get; set; }
    public ProductionTimeStatus? KitHazirlamaState { get; set; } 
    public ProductionTimeStatus? KitDogrulamaState { get; set; } 
    public int? WorkCentreId { get; set; }  
    public int? ProductionId { get; set; }
    // public string RouteStatus { get; set; }
    public bool State { get; set; }
}