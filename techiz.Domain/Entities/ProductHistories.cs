using techiz.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using techiz.Domain.Auth;

namespace techiz.Domain.Entities
{

    public class ProductHistories : BaseSimpleModel
    {
        public ProductHistories()
        {   
        }
        
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int WorkProcessRouteId { get; set; }
        public virtual WorkProcessRoute WorkProcessRoute { get; set; }

        public DateTimeOffset? BeginDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public double? ElapsedTime { get; set; }
        public Guid? UserId { get; set; }
        public virtual User User { get; set; }
        public string Explination { get; set; }
        public bool IsFininshed { get; set; }

        [Column(TypeName = "jsonb")]
        public string Metarialds { get; set; }

    }
}