using System.ComponentModel.DataAnnotations;

namespace techiz.Domain.Enum
{
    public enum MaterailReadState
    {
        [Display(Name = "Okutuldu")]
        ReadOk = 1,
        [Display(Name = "Eksik Malzeme")]
        MissingMAterial = 2,
        [Display(Name = "Üretim Sahasında")]
        OnProtuction = 3,
       
    }
}
