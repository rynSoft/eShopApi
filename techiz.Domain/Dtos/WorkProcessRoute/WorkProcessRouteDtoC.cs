using System;
using techiz.Domain.Auth;
using techiz.Domain.Entities;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class WorkProcessRouteDtoC
{
    public int? Id { get; set; }
    public Guid? RouteId { get; set; }
   
    public string Name { get; set; }
    public string VirtualName { get; set; }
    public int ProductionId { get; set; }
    public int WorkProcessTemplateId { get; set; }
    public bool State { get; set; }
    public bool Active { get; set; }
    public int Order { get; set; }
    public string WhichPage { get; set; }
}