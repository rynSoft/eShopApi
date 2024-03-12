using System;
using System.Collections.Generic;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class WorkProcessTemplateDtoQ
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Content { get { return Name; } }
    public string Version { get; set; }
    public string WhichPage { get; set; }
    public string Color { get; set; }
    public string Icon { get; set; }
    public int WorkProcessTemplateId { get; set; }
    public List<WorkProcessRouteUserDtoQ> UserList { get; set; }
}