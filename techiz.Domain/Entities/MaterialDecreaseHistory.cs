using techiz.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using techiz.Domain.Enum;

namespace techiz.Domain.Entities
{

    public class MaterialDecreaseHistory : BaseSimpleModel
    {
        public MaterialDecreaseHistory()
        {
        }

        public int? WorkProcessRouteId { get; set; }
        public virtual WorkProcessRoute WorkProcessRoute { get; set; }
        public int? MaterialId { get; set; }
        public virtual Material Material { get; set; }
        public int? ProductHistoriesId { get; set; }
        public virtual ProductHistories ProductHistories { get; set; }
        public string? Description { get; set; }
        public double? Quantity { get; set; }
    }
}