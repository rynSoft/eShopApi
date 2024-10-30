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

    public class SetupVerificationDChange : BaseSimpleModel
    {
        public SetupVerificationDChange()
        {
        }

        public int ProductionId { get; set; }
        public virtual Production Production { get; set; } 
        public int MachineId { get; set; }
        public virtual Machine Machine { get; set; } 
        public int SetupVerificationDetailsOldId { get; set; }
        public virtual SetupVerificationDetails SetupVerificationDetailsOld { get; set; } 
        public int SetupVerificationDetailsNewId { get; set; }
        public virtual SetupVerificationDetails SetupVerificationDetailsNew { get; set; } 
       
        public int OldPanelId { get; set; }
        public virtual ProductionOperations OldPanel { get; set; } 
        
        public int NewPanelId { get; set; }
        public virtual ProductionOperations NewPanel { get; set; }
        public double? OldPanelQty { get; set; }

        public double? NewPanelQty { get; set; }
    }
}