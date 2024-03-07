using techiz.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using techiz.Domain.Auth;
using techiz.Domain.Enum;

namespace techiz.Domain.Entities
{

    public class ProductionLog : BaseSimpleModel
    {
        public ProductionLog()
        {
        }

        public int ProductionId { get; set; }
        public virtual Production Production { get; set; }

        public virtual Machine Machine { get; set; }
        public Guid UserId { get; set; } 
        public virtual User User { get; set; }
        
        public ProductionProcess ProductionProcess { get; set; }
        public DateTimeOffset Date { get; set; }

        
        public string Message { get; set; }
    }
}