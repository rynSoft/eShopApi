using eShop.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eShop.Domain.Auth;

namespace eShop.Domain.Entities
{

    public class ShiftDefinitionProcess : BaseSimpleModel
    {
        public ShiftDefinitionProcess()
        {
        }

        public int ShiftDefinitionId { get; set; }   
        public virtual ShiftDefinition ShiftDefinition { get; set; }
        public int? LineId { get; set; }
        public virtual Line Line { get; set; }
        public Guid? UserId { get; set; }
        public virtual User User { get; set; }
        public string Explanation { get; set; }
        public int? TargetQuantity { get; set; }
        public int? TeoricSpeed { get; set; }
    }
}