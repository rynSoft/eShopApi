using System;

namespace techiz.Domain.Dtos;

public class WorkProcessRouteMaterialsDtoC
{
    public int? Id { get; set; }
    public int Number { get; set; }
    public bool Active { get; set; } = true;
    public string Name { get; set; }
}