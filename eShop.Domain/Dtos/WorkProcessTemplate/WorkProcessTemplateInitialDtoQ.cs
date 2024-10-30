using System;
using System.Collections;
using System.Collections.Generic;
using eShop.Domain.Entities;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos.WorkProcessTemplate;

public class WorkProcessTemplateInitialDtoQ
{
    public WorkProcessTemplateInitialDtoQ()
    {
        List1 = new();
        List2 = new();
    }

    public List<WorkProcessTemplateDtoQ> List1 { get; set; }
    public List<WorkProcessRouteDtoQ> List2 { get; set; }
}