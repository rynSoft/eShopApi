using eShop.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.Domain.Entities
{

    public class ShiftDefinition : BaseSimpleModel
    {
        public ShiftDefinition()
        {
        }

        public string  Name { get; set; }
        public TimeSpan StartDate { get; set; }
        public TimeSpan EndDate { get; set; } 
        public virtual HashSet<ShiftDefinitionProcess> ShiftDefinitionProcess { get; set; }
        

        public virtual HashSet<ShiftTargetParameters> ShiftTargetParameters { get; set; }
    }
}