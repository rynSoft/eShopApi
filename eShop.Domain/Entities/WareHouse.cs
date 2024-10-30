using eShop.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eShop.Domain.Enum;

namespace eShop.Domain.Entities
{

    public class WareHouse : BaseSimpleModel
    {
        public WareHouse ()
        {
            BomKitInfo = new();
        }
        
        public string Code  { get; set; }
        public string Name { get; set; }
        public string BarcodeCode { get; set; }
        public string Description { get; set; }
        public virtual  HashSet<BomKitInfo> BomKitInfo { get; set; }
        
    }
}