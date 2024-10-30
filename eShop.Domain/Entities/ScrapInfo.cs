using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.Domain.Entities
{

    public class ScrapInfo : BaseSimpleModel
    {
        public ScrapInfo()
        {
        }
   
        public string Explanation { get; set; }
        public string VirtualName { get; set; }
        public int WorkProcessRouteId { get; set; }
        public virtual WorkProcessRoute WorkProcessRoute { get; set; }
        public int? MaterialId { get; set; }
        public virtual Material Material { get; set; }
        public int Quantity { get; set; }
    }
}