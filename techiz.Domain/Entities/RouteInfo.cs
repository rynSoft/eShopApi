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

    public class RouteInfo : BaseSimpleModel
    {
        public RouteInfo()
        {
            
        }
        
        public int? Operation { get; set; }
        public int ProductionId { get; set; }
        public bool State { get; set; } 
        public int Order { get; set; }
        public virtual Production Production { get; set; }
        public Guid? UserId { get; set; }
        public virtual User User { get; set; }
        public int WorkCentreId { get; set; }
        public virtual WorkCentre WorkCentre { get; set; }
        public string Explanation { get; set; }
        public RouteStatus RouteStatus { get; set; }
        public ProductionProcess ProductionProcess { get; set; }
        public virtual HashSet<RouteInfoUser> RouteInfoUser { get; set; }
    }
}