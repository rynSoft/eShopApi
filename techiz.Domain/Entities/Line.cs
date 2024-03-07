using techiz.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using techiz.Domain.Enum;

namespace techiz.Domain.Entities
{

    public class Line : BaseSimpleModel
    {
        public Line ()
        {
            Machine = new();
        }
        
        public int Number { get; set; }
        public string Name { get; set; }
        public virtual  HashSet<Machine> Machine { get; set; }
        public virtual  HashSet<ShiftDefinitionProcess> ShiftDefinitionProcess { get; set; }
        public virtual HashSet<ShiftTargetParameters> ShiftTargetParameters { get; set; }

    }
}