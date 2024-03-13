using System;
using System.Collections.Generic;
using techiz.Domain.Entities;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

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
    public string Color => "light-warning";
    public string Icon => "";
    public int ProductionId { get; set; }
    public int WorkProcessTemplateId { get; set; }
    public bool State { get; set; }
    public int Order { get; set; }
    public bool Active { get; set; }
    //public WorkProcessTemplateDtoQ WorkProcessTemplateDtoQ { get; set; }
    public List<UserRouteInfoDto> UserList { get; set; }
}