using System;

namespace techiz.Domain.Dtos;

public class WorkProcessRouteMaterialsDtoQ
{
    public int? Id { get; set; }
    public int WorkProcessRouteId { get; set; }
    public int MaterialId { get; set; }
    public string Explanation { get; set; }
}