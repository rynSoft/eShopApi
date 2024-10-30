using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.Domain.Entities
{

    public class WorkProcessRouteTemplate : BaseSimpleModel
    {
        public WorkProcessRouteTemplate()
        {
        }

        public Guid? RouteId { get; set; }
        public string Name { get; set; }
        public string VirtualName { get; set; }
        public int WorkProcessTemplateId { get; set; }
        public virtual WorkProcessTemplate WorkProcessTemplate { get; set; }
        public bool State { get; set; }
        public int Order { get; set; }
        [Column(TypeName = "jsonb")]
        public string OtherObjects { get; set; }
        public string Img { get; set; }
        public string ProgressColor { get; set; }
        public string Explanation { get; set; }
    }
}