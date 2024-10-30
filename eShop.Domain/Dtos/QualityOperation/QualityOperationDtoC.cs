using System;
using eShop.Domain.Auth;
using eShop.Domain.Entities;
using eShop.Domain.Enum;

namespace eShop.Domain.Dtos;

public class QualityOperationDtoC
{
    public int Id { get; set; }
    public Guid UserLiableId { get; set; }
    public Guid AuthorizedPersonId { get; set; }
    public Guid UserApprovingId { get; set; }
    public string Operation { get; set; }

    public DateTimeOffset? StartOperationDate { get; set; }
    public Boolean? StartOperation { get; set; }

    public DateTimeOffset? EndOperationDate { get; set; }
    public Boolean? EndOperation { get; set; }

    public int QualityId { get; set; }
    public Boolean Confirmation { get; set; } = false;
}