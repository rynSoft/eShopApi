using techiz.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace techiz.Domain.Entities
{

    public class ProductHistories : BaseSimpleModel
    {
        public ProductHistories()
        {   
        }
        
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int WorkProcessRouteId { get; set; }
        public virtual WorkProcessRoute WorkProcessRoute { get; set; }
    }
}