using techiz.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using techiz.Domain.Enum;

namespace techiz.Domain.Entities
{

    public class WorkCentre : BaseSimpleModel
    {
        public WorkCentre()
        {
            RouteInfo = new();
        }
        
        public string Name { get; set; }
        public virtual HashSet<RouteInfo> RouteInfo { get; set; }
 
    }
}