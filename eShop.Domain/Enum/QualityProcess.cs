using System.ComponentModel.DataAnnotations;

namespace eShop.Domain.Enum
{
    public enum QualityProcess
    {
        [Display(Name = "Quality Confirmation")]
        QualityConfirmation = 1,
        [Display(Name = "Quality Operation")]
        QualityOperation =2,

        [Display(Name = "Quality Completed")]
        QualityCompleted = 3,
    }
}
