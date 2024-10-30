using System;
using System.Collections.Generic;
using eShop.Domain.Auth;
using eShop.Domain.Entities;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class QualityAndOperationDtoQ
{
    public Quality quality { get; set; }

    public List<QualityOperation> operationList { get; set; }
}