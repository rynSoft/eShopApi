using System.ComponentModel.DataAnnotations;

namespace eShop.Domain.Enum
{
    public enum RouteStatus
    {
        [Display(Name = "Bekleniyor")]
        Waiting = 1,
        [Display(Name = "Devam Ediyor")]
        InProgress = 2,
        [Display(Name = "Bitti")]
        Done = 3,
    }
}
