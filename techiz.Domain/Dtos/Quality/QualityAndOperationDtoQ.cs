using System;
using System.Collections.Generic;
using techiz.Domain.Auth;
using techiz.Domain.Entities;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class QualityAndOperationDtoQ
{
    public Quality quality { get; set; }

    public List<QualityOperation> operationList { get; set; }
}