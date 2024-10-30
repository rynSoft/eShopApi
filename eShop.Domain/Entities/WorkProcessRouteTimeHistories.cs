using techiz.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using techiz.Domain.Auth;
using techiz.Domain.Enum;

namespace techiz.Domain.Entities
{
    public class WorkProcessRouteTimeHistories : BaseSimpleModel
    {
        public WorkProcessRouteTimeHistories()
        {
        }
        public int WorkProcessRouteId { get; set; }
        public virtual WorkProcessRoute WorkProcessRoute { get; set; }
    
        public int? RestCauseId { get; set; }
        public virtual RestCause RestCause { get; set; }
      
         public Guid UserId { get; set; }
         public virtual User User { get; set; }

        public int? ShiftTargetParametersId { get; set; }
        public virtual ShiftTargetParameters ShiftTargetParameters { get; set; }
         public WorkProcessRouteTimeStatus WorkProcessRouteTimeStatus { get; set; }

        public DateTimeOffset StartDate { get; set; } = DateTime.UtcNow;
        public DateTimeOffset? EndDate { get; set; }
        public TimeSpan ElapsedTime { get; set; }
        public string Definition { get; set; }
    }
}