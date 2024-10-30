using eShop.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eShop.Domain.Auth;

namespace eShop.Domain.Entities
{

    public class ShiftTargetParameters : BaseSimpleModel
    {
        public ShiftTargetParameters()
        {
            WorkProcessRouteTimeHistories = new();
        }
        public int ShiftDefinitionId { get; set; }
        public virtual ShiftDefinition ShiftDefinition { get; set; }
        public double TheoreticalSpeed { get; set; }
        public int NumberOfCard { get; set; }
        public bool IsFinished { get; set; }
        public int DelayTime { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public TimeSpan DifferanceDate { get; set; }
        public int? RestCauseId { get; set; }
        public virtual RestCause RestCause { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public int LineId { get; set; }
        public virtual Line Line { get; set; }
        public int? TargetCardCount { get; set; }
        public virtual HashSet<ProductionOperations> ProductionOperations { get; set; }
        public virtual HashSet<ProductionTimeProcess> ProductionTimeProcess { get; set; }
        public virtual HashSet<WorkProcessRouteTimeHistories> WorkProcessRouteTimeHistories { get; set; }

    }
}