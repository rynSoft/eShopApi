﻿using System.ComponentModel.DataAnnotations;

namespace techiz.Domain.Enum
{
    public enum KategoriTipi
    {
        [Display(Name = "Kiralık")]
        Kiralik = 1,
        [Display(Name = "Satılık")]
        Satilik = 2,
    }
}
