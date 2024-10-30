using techiz.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using techiz.Domain.Auth;
using techiz.Domain.Enum;

namespace techiz.Domain.Entities
{

    public class ProductionUserRelation : BaseSimpleModel
    {
        public ProductionUserRelation()
        {
        }
        
        public int ProductionId { get; set; }
        public virtual Production Production { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        public ProductionProcess ProductionProcess { get; set; }
    }
}