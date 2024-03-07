using System;
using System.Collections.Generic;
using techiz.Domain.Auth;
using techiz.Domain.Entities;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class QualityAndOperationDtoC
{
    public QualityDtoC quality { get; set; }

    public QualityOperationDtoC[] operationList { get; set; }
}