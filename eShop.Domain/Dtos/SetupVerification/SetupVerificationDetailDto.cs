using System;
using System.Collections.Generic;
using eShop.Domain.Dtos;

namespace eShop.Domain;

public class SetupVerificationDetailDto
{
    public int? Id { get; set; }
     public int? SetupVerificationId { get; set; }
     public int? MachineId { get; set; }
    public double Quantity { get; set; }
    public double? FinishingQuantity { get; set; }
    public double? RollerQuantity { get; set; }
    public double? UsingQuantity { get; set; } = 0;
    public string Material { get; set; }
    public string PartyNumber { get; set; }
    public bool? IsCompleted { get; set; }
    public bool? State { get; set; }
    
    public int? SetNo { get; set; }
    public int? SiraNo { get; set; }
    public int? BomKitInfoId { get; set; }
    public int? ChangingBomKitInfoId { get; set; }
    
    
}

