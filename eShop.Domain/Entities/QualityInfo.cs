using eShop.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eShop.Domain.Enum;

namespace eShop.Domain.Entities
{
    public class QualityInfo : BaseSimpleModel
    {
        public QualityInfo()
        {
          
        }
        public QualityProcessType QualityProcessType { get; set; }
        public string ProductionCode { get; set; }
        public string LotInformation { get; set; }
        public string Description { get; set; }
        public double Piece { get; set; }

        public int QualityId { get; set; }
        public virtual Quality Quality { get; set; }
        public int QualityOperationId { get; set; }
        public virtual QualityOperation QualityOperation { get; set; }
     

    }
}