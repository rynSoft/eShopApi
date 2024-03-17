using techiz.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace techiz.Domain.Entities
{

    public class ProductionInput : BaseSimpleModel
    {
        public ProductionInput()
        {   
        }
        
        public string Qrcode { get; set; }
        public int ProductionId { get; set; }
        public virtual Production Production { get; set; }
        public int EndWorkProcessRouteId { get; set; }
        public virtual WorkProcessRoute WorkProcessRoute { get; set; }
        public virtual HashSet<ProductionInputHistories> ProductionInputHistories { get; set; }
    }
}