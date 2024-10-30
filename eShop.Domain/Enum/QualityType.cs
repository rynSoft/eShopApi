using System.ComponentModel.DataAnnotations;

namespace eShop.Domain.Enum
{
    public enum QualityType
    {
        [Display(Name = "Repair")]
        Repair = 1,
        [Display(Name = "Rework")]
        Rework = 2,
   
    }
}
