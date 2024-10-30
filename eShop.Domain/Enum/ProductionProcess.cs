using System.ComponentModel.DataAnnotations;

namespace techiz.Domain.Enum
{
    public enum ProductionProcess
    {
        [Display(Name = "Created")]
        Created = 1,
        [Display(Name = "Kit Provision")]
        KitProvision = 2,
        [Display(Name = "Kit Verification")]
        KitVerification = 3,
        [Display(Name = "Setup Verification")]
        SetupVerification = 4,
        [Display(Name = "Production Process")]
        ProductionProcess = 5,
        [Display(Name = "Production Process Secret")]
        ProductionProcessSecret = 6,
        [Display(Name = "Production Process Labeling")]
        ProductionProcessLabeling = 7,
        [Display(Name = "Production Process DisplayAssembly")]
        ProductionProcessDisplayAssembly = 8,
        [Display(Name = "Production Process Programming")]
        ProductionProcessProgramming = 9,
        [Display(Name = "Production Process DetachFromPanel")]
        ProductionProcessDetachFromPanel = 10,
        [Display(Name = "Production Process Test")]
        ProductionProcessTest = 11,

    }
}
