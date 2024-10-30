using eShop.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eShop.Domain.Enum;

namespace eShop.Domain.Entities
{

    public class Material : BaseSimpleModel
    {
        public Material()
        {
        }
        
        public string? Code { get; set; }
        public string Name { get; set; }
        public string? Explanation { get; set; }
        public string? Description { get; set; }
        public string PartyNumber { get; set; }
        public double? Quantity { get; set; }
        public double? RemainQuantity { get; set; }
        public double? DecreaseQuantity { get; set; }
        public string Unit { get; set; }
        public  bool IsDone { get; set; }
        public int? NextWPRId { get; set; }

    }
}