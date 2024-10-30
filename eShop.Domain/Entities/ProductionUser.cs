using eShop.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eShop.Domain.Auth;
using eShop.Domain.Enum;

namespace eShop.Domain.Entities
{

    public class ProductionUser : BaseSimpleModel
    {
        public ProductionUser()
        {
        }
        public int ProductionId { get; set; }
        public virtual Production Production { get; set; } 
        public Guid UserId { get; set; } 
        public virtual User User { get; set; }
        
        public ProductionProcess ProductionProcess { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Message { get; set; }
        public bool OpenState { get; set; } = false;
    }
}