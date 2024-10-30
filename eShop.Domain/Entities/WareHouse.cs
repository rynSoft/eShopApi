using techiz.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using techiz.Domain.Enum;

namespace techiz.Domain.Entities
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