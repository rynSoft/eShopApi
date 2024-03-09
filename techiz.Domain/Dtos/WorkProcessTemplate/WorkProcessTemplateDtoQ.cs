using System;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class WorkProcessTemplateDtoQ
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public string Version { get; set; }
    public string Color { get; set; }
    public string Icon { get; set; }
}