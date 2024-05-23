using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace techiz.Domain.Dtos;

public class WorkProcessRouteTemplateDtoC
{
    public int? Id { get; set; }
    public Guid? RouteId { get; set; }
    public string Name { get; set; }
    public string VirtualName { get; set; }
    public int WorkProcessTemplateId { get; set; }
    public bool State { get; set; }
    public int Order { get; set; }
    public string OtherObjects { get; set; }
    public string Img { get; set; }
    public string ProgressColor { get; set; }
    public string Explanation { get; set; }
}