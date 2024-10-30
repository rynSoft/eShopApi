using System;
using System.Collections.Generic;
using eShop.Domain.Auth;

namespace eShop.Domain.Entities
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
        public int Order { get; set; }
        public string Explanation { get; set; }


    }
}