using techiz.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using techiz.Domain.Enum;

namespace techiz.Domain.Entities
{

    public class ProductionMachineMatch : BaseSimpleModel
    {
        public ProductionMachineMatch()
        {
        }
        public int MachineId { get; set; }
        public virtual Machine Machine { get; set; }
        public int ProductionId { get; set; } 
        public int? ElapsedTime { get; set; }
        public virtual Production Production { get; set; } 
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public bool? State { get; set; }
       
        
    }
}