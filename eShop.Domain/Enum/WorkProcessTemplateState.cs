using System.ComponentModel.DataAnnotations;

namespace techiz.Domain.Enum
{
    public enum WorkProcessTemplateState
    {
        [Display(Name = "Product")]
        Product = 1,
        [Display(Name = "ProductHistories")]
        ProductHistories = 2,
        [Display(Name = "Material")]
        Material = 3,
        [Display(Name = "MaterialHistories")]
        MaterialHistories = 4,
        [Display(Name = "Template")]
        Template = 5,
       
    }
}
