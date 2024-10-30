using System;
using System.Collections.Generic;
using techiz.Domain.Dtos;

namespace techiz.Domain;

public class SetupVerificationResult
{
    public int SetupVerificationId { get; set; }
    public double? RollerQuantity { get; set; }
    
    public int NewBomKitInfoId { get; set; }

}

