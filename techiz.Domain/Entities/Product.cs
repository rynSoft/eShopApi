using System;
using System.Collections.Generic;
using techiz.Domain.Auth;

namespace techiz.Domain.Entities
{
    public class Product : BaseSimpleModel
    {
        public Product()
        {   
        }
        
        public string Qrcode { get; set; }
        public int ProductionId { get; set; }
        public virtual Production Production { get; set; }
        public Guid? UserId { get; set; }
        public virtual User User { get; set; }
        public int NextWPRId { get; set; }
        public virtual WorkProcessRoute NextWPR { get; set; }
        public int Order { get; set; }
        public virtual HashSet<ProductHistories> ProductionInputHistories { get; set; }

        
    }
}