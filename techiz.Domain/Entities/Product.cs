using System.Collections.Generic;

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
        public int EndWorkProcessRouteId { get; set; }
        public virtual WorkProcessRoute WorkProcessRoute { get; set; }
        public virtual HashSet<ProductHistories> ProductionInputHistories { get; set; }
    }
}