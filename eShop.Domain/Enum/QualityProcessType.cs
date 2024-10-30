using System.ComponentModel.DataAnnotations;

namespace eShop.Domain.Enum
{
    public enum QualityProcessType
    {
        [Display(Name = "Ekle")]
        Ekle = 1,
        [Display(Name = "Çıkar")]
        Çıkar = 2,
    
    }
}
