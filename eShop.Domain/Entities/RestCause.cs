using eShop.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eShop.Domain.Enum;

namespace eShop.Domain.Entities
{
    public class RestCause : BaseSimpleModel
    {
        public RestCause()
        {
            ProductionTimeProcess = new();
        }
        
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Hanging { get; set; } = false;
        public bool UseOee { get; set; } = true;
        public virtual HashSet<ProductionTimeProcess> ProductionTimeProcess { get; set; }
        public virtual HashSet<ShiftTargetParameters> ShiftTargetParameters { get; set; }
        public virtual HashSet<WorkProcessRouteTimeHistories> WorkProcessRouteTimeHistories { get; set; }
    }
}