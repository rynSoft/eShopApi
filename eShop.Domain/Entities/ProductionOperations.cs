using eShop.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eShop.Domain.Enum;

namespace eShop.Domain.Entities
{
    public class ProductionOperations : BaseSimpleModel
    {
        public ProductionOperations()
        {
            OldPanel = new();
            NewPanel = new();
        }
        
        public string QrCode { get; set; }
        public int GecenSure { get; set; }
        [Column(TypeName = "jsonb")]
        public string FeedlerData { get; set; }
        public int ProductionId { get; set; }
       
        public virtual Production Production { get; set; }
        public int MachineId { get; set; }
        public virtual Machine Machine { get; set; }

        public int? ShiftTargetParametersId { get; set; }
        public virtual ShiftTargetParameters ShiftTargetParameters { get; set; }

        public DateTimeOffset? OperationDate { get; set; } 
        public OperationProcess OperationProcess { get; set; }
        [NotMapped]
        public virtual HashSet<SetupVerificationDChange> OldPanel { get; set; }
        [NotMapped]
        public virtual HashSet<SetupVerificationDChange> NewPanel { get; set; }
        public virtual HashSet<ProductionProcessManualTest> ProductionProcessManualTest { get; set; }
        
    }
}