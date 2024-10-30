using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.Domain
{
    public class BaseSimpleModel : IBaseSimpleModel
    {
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public bool IsDeleted { get; set; } = false;
        public bool Active { get; set; } = true;
        public Guid? CreatorId { get; set; }
        public Guid? EditorId { get; set; }
        public DateTimeOffset? CreateDate { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset? EditDate { get; set; }
    }
}
