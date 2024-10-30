using eShop.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.Domain.Entities
{

    public class Production : BaseSimpleModel
    {
        public Production()
        {
        }
        
        public string OrderNo { get; set; }
        public int Quantity { get; set; }
        public int?  EstimatedTime { get; set; }
        public int? PanelCardCount { get; set; }
        public DateTimeOffset? StartDate { get; set; } 
        public string UretimAdi { get; set; }
        public string Aciklama { get; set; }
        public virtual HashSet<Product> Product { get; set; }
        



    }
}