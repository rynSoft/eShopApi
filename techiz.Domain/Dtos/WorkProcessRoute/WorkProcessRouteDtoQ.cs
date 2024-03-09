using System;
using System.Collections.Generic;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class WorkProcessRouteDtoQ 
{
    public WorkProcessRouteDtoQ()
    {
    }
    public int? Id { get; set; }
    public Guid? RouteId { get; set; }
    public string Name { get; set; }
    public string VirtualName { get; set; }
    public int ProductionId { get; set; }
    public bool State { get; set; }
    public int Order { get; set; }
    public List<UserRouteInfoDto> UserList { get; set; }
}