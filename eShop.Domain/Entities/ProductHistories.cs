using eShop.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eShop.Domain.Auth;

namespace eShop.Domain.Entities
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
        public string Explanation { get; set; }
        public bool IsFinished { get; set; }
        public virtual HashSet<MaterialDecreaseHistory> MaterialDecreaseHistory { get; set; }

    }
}