using techiz.Domain;
using System;
using techiz.Domain.Auth;
using techiz.Domain.Enum;

namespace techiz.Domain.Entities
{

    public class WorkProcessTemplate : BaseSimpleModel
    {
        public WorkProcessTemplate()
        {
        }
     
        public string Name { get; set; }
        public string Version { get; set; }
        public string Color { get; set; }
        public string Icon { get; set; }
    }
}