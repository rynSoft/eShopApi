using techiz.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace techiz.Domain.Entities
{

    public class Production : BaseSimpleModel
    {
        public Production()
        {
            BomKitInfo = new();
            RouteInfo = new();
            ProductionTimeProcess = new();
            ProductionUser = new();
            ProductionLog = new();
            SetupVerification = new();
            ProductionProcessManual = new();
        }
        
        public string OrderNo { get; set; }
        public int Quantity { get; set; }
        public int?  EstimatedTime { get; set; }
        public int? PanelCardCount { get; set; }
        public DateTimeOffset? StartDate { get; set; } 
        public string UretimAdi { get; set; }
        public string Aciklama { get; set; }
        
        public virtual HashSet<BomKitInfo> BomKitInfo { get; set; }
        public virtual HashSet<RouteInfo> RouteInfo { get; set; }
        public virtual HashSet<ProductionTimeProcess> ProductionTimeProcess { get; set; }
         public virtual HashSet<ProductionUser> ProductionUser { get; set; }
        public virtual HashSet<ProductionLog> ProductionLog { get; set; }
        public virtual HashSet<SetupVerificationInfo> SetupVerificationInfo { get; set; }
        public virtual HashSet<ProductionOperations> ProductionOperations { get; set; }
        public virtual HashSet<SetupVerificationDChange> SetupVerificationDChange { get; set; }
        public virtual HashSet<ProductionProcessManual> ProductionProcessManual { get; set; }
        public virtual HashSet<ProductionProcessManualTest> ProductionProcessManualTest { get; set; }
        

        public virtual HashSet<SetupVerification> SetupVerification { get; set; }
        

    }
}