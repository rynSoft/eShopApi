using System;
using System.Collections.Generic;
using techiz.Domain.Entities;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class WorkProcessRouteDashboardDtoQ
{
    public WorkProcessRouteDashboardDtoQ()
    {
    }

    public int Progress { get; set; }
    public int Order { get; set; }
    public string ProgressColor { get; set; }
    public string SubTitle { get; set; }
    public string Title { get; set; }
    public string Img { get; set; }

}