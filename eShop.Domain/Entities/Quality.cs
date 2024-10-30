using eShop.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eShop.Domain.Enum;
using eShop.Domain.Auth;

namespace eShop.Domain.Entities
{
    public class Quality : BaseSimpleModel
    {
      
            public Quality()
            {
     
            }
            public string WorkOrderNumber { get; set; }
            public string ProductionCode { get; set; }
            public string SerialCode { get; set; }
            public double Piece { get; set; }
        public bool State { get; set; }
        public string NonComplianceCode { get; set; }

            public QualityType QualityType { get; set; }
      

    }
}