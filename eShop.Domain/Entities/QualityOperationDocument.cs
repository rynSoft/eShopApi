using eShop.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eShop.Domain.Enum;

namespace eShop.Domain.Entities
{

    public class QualityOperationDocument : BaseSimpleModel
    {
        public QualityOperationDocument()
        {
            
        }
        public int QualityOperationId { get; set; }
        public virtual QualityOperation QualityOperation { get; set; }
        public byte[] Data { get; set; }
        public string DataType { get; set; }
        public string Description { get; set; }

    }
}