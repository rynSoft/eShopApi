using eShop.Domain;
using System;
using eShop.Domain.Auth;
using eShop.Domain.Enum;
using System.Collections.Generic;

namespace eShop.Domain.Entities
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
        public WorkProcessTemplateState? WPTState { get; set; }
        public virtual HashSet<WorkProcessRoute> WorkProcessRoute { get; set; }
        
    }
}