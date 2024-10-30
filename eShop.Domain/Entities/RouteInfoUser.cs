using eShop.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eShop.Domain.Auth;
using eShop.Domain.Enum;

namespace eShop.Domain.Entities
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