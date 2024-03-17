using techiz.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace techiz.Domain.Entities
{

    public class ProductionInputHistories : BaseSimpleModel
    {
        public ProductionInputHistories()
        {   
        }
        
        public int ProductionInputId { get; set; }
        public virtual ProductionInput ProductionInput { get; set; }
        public int WorkProcessRouteId { get; set; }
        public virtual WorkProcessRoute WorkProcessRoute { get; set; }
    }
}