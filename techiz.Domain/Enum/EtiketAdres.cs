﻿using System.ComponentModel.DataAnnotations;

namespace techiz.Domain.Enum
{
    public enum EtiketAdres
    {
        [Display(Name = "Bölge")]
        Bolge = 1,
        [Display(Name = "Kategori")]
        Kategori = 2,
        [Display(Name = "VillaGorunum")]
        VillaGorunum = 3
    }
}
