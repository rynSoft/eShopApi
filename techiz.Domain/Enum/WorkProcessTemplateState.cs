using System.ComponentModel.DataAnnotations;

namespace techiz.Domain.Enum
{
    public enum WorkProcessTemplateState
    {
        [Display(Name = "Product")]
        Product = 1,
        [Display(Name = "Material")]
        Material = 2,
        [Display(Name = "Template")]
        Template = 3,
       
    }
}
