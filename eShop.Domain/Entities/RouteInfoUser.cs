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

    public class RouteInfoUser : BaseSimpleModel
    {
        public RouteInfoUser()
        {
        }
        

        public int RouteInfoId { get; set; }
        public virtual RouteInfo RouteInfo { get; set; }
        public Guid? UserId { get; set; }
        public virtual User User { get; set; }
    }
}