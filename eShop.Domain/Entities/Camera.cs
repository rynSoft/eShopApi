using eShop.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eShop.Domain.Enum;

namespace eShop.Domain.Entities
{

    public class Camera : BaseSimpleModel
    {
        public Camera()
        {
        }
        
        public string Code { get; set; }
        public string Name { get; set; }
        public string? IpAdress { get; set; }
        public int? Port { get; set; }

    }
}