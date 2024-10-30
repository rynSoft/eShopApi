using System;
using System.Collections.Generic;

namespace eShop.Infrastructure.ViewModel
{
    public class RoleViewModel
    {
        public string Name { get; set; }
        
        public List<UserViewModel> users { get; set; }
    }
}
