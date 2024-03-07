using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using techiz.Persistence;

namespace techiz.Service
{
    public static class HttpContextUtilities
    {
        public static Guid? GetCurrentUser(this Microsoft.AspNetCore.Http.HttpContext context)
        {
            var appDbContext = context.RequestServices.GetService<appDbContext>();

            if (context.Request.Headers.Any(c => c.Key == "Authorization"))
            {
                var tk = context.Request.Headers.FirstOrDefault(c => c.Key == "Authorization").Value.ToString().Split(' ')[1];
                var token = appDbContext.RefreshToken.FirstOrDefault(c => c.Token == tk.Replace(@"""", ""));
                if (token != null && appDbContext.Users.Find(token.UserId) != null)
                    return appDbContext.Users.Find(token.UserId).Id;
            }

            return null;
        }
    }
}
