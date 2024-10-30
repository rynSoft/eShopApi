using System;
using System.Collections.Generic;
using eShop.Domain.Dtos;

namespace eShop.Domain;

public class SetupVerificationDto
{
    public int? Id { get; set; }
    public int ProductionId { get; set; }
    public int MachineId { get; set; }

    public  int? OldBomKitInfoId { get; set; }
    public  string ChangeMaterialCode { get; set; }
    public HashSet<SetupVerificationDetailDto> SetupVerificationDetail { get; set; }
    public bool Active { get; set; }
    public int? SetNo { get; set; }
    public Guid? UserId { get; set; }
    public Guid? CreatorId { get; set; }

}


