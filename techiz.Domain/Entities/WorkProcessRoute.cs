using techiz.Domain;
using System;
using techiz.Domain.Auth;
using techiz.Domain.Enum;

namespace techiz.Domain.Entities
{

    public class WorkProcessRoute : BaseSimpleModel
    {
        public WorkProcessRoute()
        {
        }

        public Guid? RouteId { get; set; }
        public string Name { get; set; }
        public string VirtualName { get; set; }
        public int ProductionId { get; set; }
        public virtual Production Production { get; set; }
        public bool State { get; set; }
        public int Order { get; set; }

    }
}