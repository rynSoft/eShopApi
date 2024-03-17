using techiz.Domain;
using System;
using techiz.Domain.Auth;
using techiz.Domain.Enum;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace techiz.Domain.Entities
{

    public class WorkProcessRoute : BaseSimpleModel
    {
        public WorkProcessRoute()
        {
            WorkProcessRouteUser = new();
        }

        public Guid? RouteId { get; set; }
        public string Name { get; set; }
        public string VirtualName { get; set; }
        public int ProductionId { get; set; }
        public virtual Production Production { get; set; }
        public int WorkProcessTemplateId { get; set; }
        public virtual WorkProcessTemplate WorkProcessTemplate { get; set; }
        public bool State { get; set; }
        public int Order { get; set; }
        [Column(TypeName = "jsonb")]
        public string OtherObjects { get; set; }
        public virtual HashSet<WorkProcessRouteUser> WorkProcessRouteUser { get; set; }
        public virtual HashSet<ProductionInput> ProductionInput { get; set; }

    }
}