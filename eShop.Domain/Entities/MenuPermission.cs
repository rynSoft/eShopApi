﻿using eShop.Domain;
using System;

namespace eShop.Domain.Entities
{
    public class MenuPermission :  BaseSimpleModel
    {
        public int MenuId { get; set; }
        public virtual Menu Menu { get; set; }
        public int PermissionId { get; set; }
        public virtual Permission Permission { get; set; }
        public string RoleId { get; set; }
    }
}
