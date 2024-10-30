using System.ComponentModel.DataAnnotations;

namespace eShop.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
