using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace techiz.Domain.Entities
{

    public class WorkProcessRouteMaterial : BaseSimpleModel
    {
        public WorkProcessRouteMaterial()
        {
        }

        public int WorkProcessRouteId { get; set; }
        public virtual WorkProcessRoute WorkProcessRoute { get; set; }
        public int MaterialId { get; set; }
        public virtual Material Material { get; set; }
    
    }
}