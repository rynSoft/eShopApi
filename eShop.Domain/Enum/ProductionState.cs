using System.ComponentModel.DataAnnotations;

namespace techiz.Domain.Enum
{
    public enum ProductionState
    {
        [Display(Name = "Başladı")]
        Created = 1,
        [Display(Name = "Durduruldu")]
        Stoped = 2,
        [Display(Name = "Tamamlandı")]
        Finished = 3,
       
    }
}
