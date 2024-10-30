using eShop.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eShop.Domain.Enum;

namespace eShop.Domain.Entities
{

    public class BomKitInfo : BaseSimpleModel
    {
        public BomKitInfo()
        {
            SetupVerificationDetails = new();
            BomKitInfoOld = new();
            BomKitInfoNew = new();
        }
        
        public int ProductionId { get; set; }
        public virtual Production Production { get; set; }
        public int? WareHouseId { get; set; }
        public string WareHouseName { get; set; }
        public virtual WareHouse WareHouse { get; set; }
        public string Material { get; set; }
        public string? Explanation { get; set; }
        public string? Description { get; set; }
        
        public string PartyNumber { get; set; }
        public double Quantity { get; set; }
        public double? RollerQuantity { get; set; }
       
        public string Unit { get; set; }
        public string SoureProductPlace { get; set; }

        public int IsKitProvided { get; set; } = 0;
        public int IsKitPreperated { get; set; } = 0;
        public bool IsSetupVerification { get; set; }
        public bool IsProductionProcess { get; set; } = false;
        public int? SetNo { get; set; }
        public virtual HashSet<SetupVerificationDetails> SetupVerificationDetails { get; set; }
        [NotMapped]
        public virtual HashSet<SetupVerificationDChange> BomKitInfoOld { get; set; }
        [NotMapped]
        public virtual HashSet<SetupVerificationDChange> BomKitInfoNew { get; set; }

        public virtual HashSet<SetupVerificationInfo> SetupVerificationInfo { get; set; }

    }
}