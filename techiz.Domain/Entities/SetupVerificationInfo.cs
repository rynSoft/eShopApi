using techiz.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using techiz.Domain.Enum;

namespace techiz.Domain.Entities
{
    public class SetupVerificationInfo : BaseSimpleModel
    {
        public SetupVerificationInfo()
        {
        }
        public int ProductionId { get; set; }
        public virtual Production Production { get; set; } 
        public int MachineId { get; set; }
  
        public virtual BomKitInfo BomKitInfo { get; set; }
        public virtual Machine Machine { get; set; } 
        public double? Decrease { get; set; }
        public double? RollerQuantity { get; set; }
        public string FileName { get; set; }
        public string JobName { get; set; }
        public int SetNo { get; set; }
        public bool IsVerificated { get; set; }
        public string Barcode { get; set; }
        public bool? IsCompleted { get; set; }
    }
}