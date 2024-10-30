using System;
using eShop.Domain.Auth;
using eShop.Domain.Entities;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class WorkProcessRouteDtoC
{
    public int? Id { get; set; }
    public Guid? RouteId { get; set; }
   
    public string Name { get; set; }
    public string VirtualName { get; set; }
    public string ProgressColor { get; set; }
    public int ProductionId { get; set; }
    public int WorkProcessTemplateId { get; set; }
    public bool State { get; set; }
    public bool Active { get; set; }
    public int Order { get; set; }
    public string WhichPage { get; set; }
}