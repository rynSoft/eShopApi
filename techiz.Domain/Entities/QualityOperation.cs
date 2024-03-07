using techiz.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using techiz.Domain.Enum;
using techiz.Domain.Auth;
using Microsoft.EntityFrameworkCore;

namespace techiz.Domain.Entities
{
    
    public class QualityOperation : BaseSimpleModel
    {
        public QualityOperation()
        {
        }

        public Guid UserLiableId { get; set; }
        public Guid UserApprovingId { get; set; }
        public Guid AuthorizedPersonId { get; set; }

        public DateTimeOffset? StartOperationDate { get; set; }
        public Boolean StartOperation { get; set; }

        public DateTimeOffset? EndOperationDate { get; set; }
        public Boolean? EndOperation { get; set; }
        public string Operation { get; set; }
        public Boolean Confirmation { get; set; } = false;
        public int QualityId { get; set; }
        public virtual Quality Quality { get; set; }
    }
}