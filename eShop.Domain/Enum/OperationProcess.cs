using System.ComponentModel.DataAnnotations;

namespace eShop.Domain.Enum
{
    public enum OperationProcess
    {
        [Display(Name = "Uretim")]
        Uretim = 1,
        [Display(Name = "Hatalı")]
        Hatalı = 2,
        [Display(Name = "Rework")]
        YenidenCalisma = 2,
    }
}
