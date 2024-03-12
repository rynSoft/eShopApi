using System;
using techiz.Domain.Auth;
using techiz.Domain.Entities;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class WorkProcessRouteDtoC
{
    public string Id { get; set; }
    public Guid? RouteId { get; set; }
   
    public string Name { get; set; }
    //public string Content { get { return Name; } }
    public string VirtualName { get; set; }
    public int ProductionId { get; set; }
    public int WorkProcessTemplateId { get; set; }
    public bool State { get; set; }
    public int Order { get; set; }
}