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

    public class SetupVerificationDetails : BaseSimpleModel
    {
        public SetupVerificationDetails()
        {
        }


        public string Material { get; set; }
        public string PartyNumber { get; set; }
        public int SetupVerificationId { get; set; }
        public virtual SetupVerification SetupVerification { get; set; } 

        public double Quantity { get; set; }
        public double? FinishingQuantity { get; set; }
        public double? RollerQuantity { get; set; }
        public double? UsingQuantity { get; set; } = 0;
        public bool? State { get; set; }
        public bool? IsCompleted { get; set; }
        public int ChangingBomKitInfoId { get; set; }
        public int SiraNo { get; set; } 
        public int? MachineId { get; set; }
        public virtual Machine Machine { get; set; } 
        public int BomKitInfoId { get; set; }
        public virtual BomKitInfo BomKitInfo { get; set; } 
        public int SetNo { get; set; }
    }
}