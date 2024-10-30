using System;
using System.Collections.Generic;
using eShop.Domain.Dtos;

namespace eShop.Domain;

public class SetupVerificationResult
{
    public int SetupVerificationId { get; set; }
    public double? RollerQuantity { get; set; }
    
    public int NewBomKitInfoId { get; set; }

}

