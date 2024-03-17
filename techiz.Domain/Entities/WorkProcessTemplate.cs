using techiz.Domain;
using System;
using techiz.Domain.Auth;
using techiz.Domain.Enum;
using System.Collections.Generic;

namespace techiz.Domain.Entities
{

    public class WorkProcessTemplate : BaseSimpleModel
    {
        public WorkProcessTemplate()
        {
            WorkProcessRoute = new();
        }
     
        public string Name { get; set; }
        public string Version { get; set; }
        public string Color { get; set; }
        public string Icon { get; set; }
        public string WhichPage { get; set; }
        public bool? IsTemplate { get; set; } = true;
        public virtual HashSet<WorkProcessRoute> WorkProcessRoute { get; set; }
        
    }
}