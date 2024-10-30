using eShop.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eShop.Domain.Enum;

namespace eShop.Domain.Entities
{

    public class NonComplianceCode : BaseSimpleModel
    {
        public NonComplianceCode()
        {
            //Quality = new();
        }
        
        public string Name { get; set; }
        //public virtual  HashSet<Quality> Quality { get; set; }
        
    }
}