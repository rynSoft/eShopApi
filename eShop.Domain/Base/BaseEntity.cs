using System.ComponentModel.DataAnnotations;

namespace techiz.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
