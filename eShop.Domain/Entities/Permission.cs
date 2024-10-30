
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eShop.Domain;

namespace eShop.Domain.Entities
{
    public class Permission : BaseSimpleModel
    {
        public string Name { get; set; }

        public virtual ICollection<MenuPermission> MenuPermission { get; set; }
    }
}
