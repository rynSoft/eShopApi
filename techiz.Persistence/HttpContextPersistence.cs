using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;


namespace techiz.Persistence
{
    public static class HttpContextPersistence
    {
        public static Guid? GetCurrentGeneralUser(this Microsoft.AspNetCore.Http.HttpContext context)
        {
            //var appDbContext = context.RequestServices.GetService<appDbContext>();

            //if (context.Request.Headers.Any(c => c.Key == "Authorization"))
            //{
            //    var tk = context.Request.Headers.FirstOrDefault(c => c.Key == "Authorization").Value.ToString().Split(' ')[1];
            //    var token = appDbContext.RefreshToken.Where(c => c.Token == tk.Replace(@"""", "")).Select(x => new { x.UserId }).FirstOrDefault();
            //    var user = appDbContext.Users.Find(token.UserId);
            //    if (token != null && user != null)
            //        return user.Id;
            //}

            return null;
        }
    }
}
