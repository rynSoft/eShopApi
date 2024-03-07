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

    public class ProductionOperationsTimeLog : BaseSimpleModel
    {
        public ProductionOperationsTimeLog()
        {
        }
        public int ProductionId { get; set; }
        public virtual Production Production { get; set; } 
        
        public int ProductionOperationsId { get; set; }
        public virtual ProductionOperations ProductionOperations { get; set; } 
        public int LastTime { get; set; }
        public int CurrentTime { get; set; }
        public string Message { get; set; }
    }
}