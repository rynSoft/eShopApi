using System;
using System.Collections.Generic;
using eShop.Domain.Entities;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class WorkProcessRouteDtoQ 
{
    public WorkProcessRouteDtoQ()
    {
    }
    public string Id { get; set; }
    public Guid? RouteId { get; set; }
    public string Name { get; set; }
    public string VirtualName { get; set; }
    public string Content { get; set; }
    public string Color { get; set; }
    public string ProgressColor { get; set; }
    public string Icon { get; set; }
    public int ProductionId { get; set; }
    public int WorkProcessTemplateId { get; set; }
    public bool State { get; set; }
    public int Order { get; set; }
    public bool Active { get; set; }
    public List<UserRouteInfoDto> UserList { get; set; }
}