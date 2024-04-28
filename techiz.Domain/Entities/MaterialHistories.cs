using techiz.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using techiz.Domain.Enum;
using techiz.Domain.Auth;

namespace techiz.Domain.Entities
{

    public class MaterialHistories : BaseSimpleModel
    {
        public MaterialHistories()
        {
        }
        
        public int MaterialId { get; set; }
        public virtual Material Material { get; set; }
        public int WorkProcessRouteId { get; set; }
        public virtual WorkProcessRoute WorkProcessRoute { get; set; }
        public DateTimeOffset? Date { get; set; }
        public Guid? UserId { get; set; }
        public virtual User User { get; set; }
        public string Explination { get; set; }
        public int? MaterialUsableState { get; set; }

        public MaterailReadState MaterailReadState { get; set; }
    }
}