using System;
using techiz.Domain.Auth;
using techiz.Domain.Entities;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class QualityOperationDtoQ
{
    public int Id { get; set; }
    public Guid UserLiableId { get; set; }
    public Guid UserApprovingId { get; set; }
    public Guid AuthorizedPersonId { get; set; }
    public string Operation { get; set; }
    public int QualityId { get; set; }
    public QualityDtoQ  Quality { get; set; }

    public DateTimeOffset? StartOperationDate { get; set; }
    public Boolean? StartOperation { get; set; }

    public DateTimeOffset? EndOperationDate { get; set; }
    public Boolean? EndOperation { get; set; }
    public DateTimeOffset EditDate { get; set; }
    public Boolean Confirmation { get; set; }
    public DateTimeOffset CreateDate { get; set; }

}