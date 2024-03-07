using techiz.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using techiz.Domain.Enum;

namespace techiz.Domain.Entities
{

    public class Machine : BaseSimpleModel
    {
        public Machine()
        {
             SetupVerification = new();
        }

        public int LineId { get; set; }
        public virtual Line Line { get; set; }
        
        public string Code { get; set; }
        public string Name { get; set; }
        public string? BarcodeReaderId { get; set; }
        public int LedNumber { get; set; }

        public virtual HashSet<ProductionLog> ProductionLog { get; set; }
        public virtual HashSet<SetupVerificationDChange> SetupVerificationDChange { get; set; }
        public virtual HashSet<ProductionTimeProcess> ProductionTimeProcess { get; set; }
        public virtual HashSet<ProductionOperations> ProductionOperations { get; set; }
        
        public virtual HashSet<SetupVerificationInfo> SetupVerificationInfo { get; set; }
        public virtual HashSet<SetupVerificationDetails> SetupVerificationDetails { get; set; }
        public virtual HashSet<SetupVerification> SetupVerification { get; set; }
    }
}