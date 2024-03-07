using System.ComponentModel.DataAnnotations;

namespace techiz.Domain.Enum
{
    public enum FiyatTuru
    {
        [Display(Name = "Gunluk")]
        Gunluk = 1,
        [Display(Name = "Haftalık")]
        Haftalık = 2,
    }
}
