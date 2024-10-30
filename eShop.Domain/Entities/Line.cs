using eShop.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eShop.Domain.Enum;

namespace eShop.Domain.Entities
{

    public class Line : BaseSimpleModel
    {
        public Line ()
        {

        }
        
        public int Number { get; set; }
        public string Name { get; set; }
    }
}