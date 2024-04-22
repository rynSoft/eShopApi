using System;
using techiz.Domain.Auth;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class WorkProcessTemplateDtoC
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public string Version { get; set; }
    public string WhichPage { get; set; }
    public string Color { get; set; }
    public string Icon { get; set; }
    public WorkProcessTemplateState? WPTState { get; set; } 
}