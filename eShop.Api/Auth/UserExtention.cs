using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace techizApi.Auth
{
    public static class UserExtention
    {

        public static ClaimsPrincipal getUser(this HttpContext http)
        {

            return null;

        }
    }
}
