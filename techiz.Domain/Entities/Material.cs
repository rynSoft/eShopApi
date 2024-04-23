using techiz.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using techiz.Domain.Enum;

namespace techiz.Domain.Entities
{

    public class Material : BaseSimpleModel
    {
        public Material()
        {
        }
        
        public int ProductionId { get; set; }
        public virtual Production Production { get; set; }
        public int? WareHouseId { get; set; }
        public virtual WareHouse WareHouse { get; set; }
        public string? Code { get; set; }
        public string Name { get; set; }
        public string? Explanation { get; set; }
        public string? Description { get; set; }
        public string PartyNumber { get; set; }
        public double? Quantity { get; set; }
        public double? RemainQuantity { get; set; }
        public double? DecreaseQuantity { get; set; }
        public string Unit { get; set; }
        public int? NextWPRId { get; set; }
        public virtual WorkProcessRoute NextWPR { get; set; }

    }
}