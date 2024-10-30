using System.ComponentModel.DataAnnotations;

namespace eShop.Domain.Enum
{
    public enum ProductionTimeStatus
    {
        [Display(Name = "Bekleniyor")]
        Waiting = 0,
        [Display(Name = "Başla")]
        Start = 1,
        [Display(Name = "Dur")]
        Pause = 2,
        [Display(Name = "Devam Et")]
        Resume = 3,
        [Display(Name = "Bitir")]
        Stop = 4,
    }
}
