using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace eShopApi.Auth
{
    public static class UserExtention
    {

        public static ClaimsPrincipal getUser(this HttpContext http)
        {

            return null;

        }
    }
}
