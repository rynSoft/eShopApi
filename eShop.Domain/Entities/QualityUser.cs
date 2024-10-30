using eShop.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eShop.Domain.Auth;
using eShop.Domain.Enum;

namespace eShop.Domain.Entities
{

    public class QualityUser : BaseSimpleModel
    {
        public QualityUser()
        {
        }
        public int QualityId { get; set; }
        public virtual Quality Quality { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        public QualityProcess QualityProcess { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Message { get; set; }
        public bool OpenState { get; set; } = false;
    }
}