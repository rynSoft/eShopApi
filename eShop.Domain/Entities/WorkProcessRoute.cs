﻿using System;
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
            WorkProcessRouteTimeHistories = new();
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
        public string Img { get; set; }
        public string ProgressColor { get; set; }
        public string Explanation { get; set; }
        public virtual HashSet<WorkProcessRouteUser> WorkProcessRouteUser { get; set; }
        public virtual HashSet<Product> Product { get; set; }
        public virtual HashSet<Material> Material { get; set; }
        public virtual HashSet<WorkProcessRouteMaterial> WorkProcessRouteMaterial { get; set; }
        
        public virtual HashSet<WorkProcessRouteTimeHistories> WorkProcessRouteTimeHistories { get; set; }
        public virtual HashSet<MaterialHistories> MaterialHistories { get; set; }


    }
}