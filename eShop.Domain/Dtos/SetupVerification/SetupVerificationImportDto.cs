using System;
using System.Collections.Generic;
using eShop.Domain.Dtos;

namespace eShop.Domain;

public class SetupVerificationImportDto
{
    public int ProductionId { get; set; }
    public int MachineId { get; set; }
    public List<SetupVerificationDetailImportDto> SetupVerification { get; set; }
    public string jobName { get; set; }

    public string FileName { get; set; }

}

public class SetupVerificationDetailImportDto
{
    public int SET_NO { get; set; }
    public string PARTS_NAME { get; set; }
    public double DECREASE { get; set; }
    public double ROLLER_QUANTITY { get; set; }
}

