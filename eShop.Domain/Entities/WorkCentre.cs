using eShop.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eShop.Domain.Enum;

namespace eShop.Domain.Entities
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