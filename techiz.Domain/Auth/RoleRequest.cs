using System.Collections.Generic;

namespace techiz.Domain.Auth
{   public class RoleRequest
    {
        public string Name { get; set; }
        public List<string> ClaimListId { get; set; }
    }
}
