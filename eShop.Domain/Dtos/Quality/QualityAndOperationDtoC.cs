using System;
using System.Collections.Generic;
using eShop.Domain.Auth;
using eShop.Domain.Entities;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class QualityAndOperationDtoC
{
    public QualityDtoC quality { get; set; }

    public QualityOperationDtoC[] operationList { get; set; }
}