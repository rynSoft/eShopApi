
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using SQLitePCL;
using eShop.Domain.Auth;
using eShop.Persistence;
using eShopApi.Auth;

namespace eShopApi.Auth
{

    public class tempClaim
    {
        public string Type { get; set; }
        public string Value { get; set; }
        public string Issuer { get; set; }
        public Guid UserId { get; set; }
    }
 
    public class YetkiDenetimi : ActionFilterAttribute, IActionFilter
    {
        private string yetki;
        public YetkiDenetimi(string yetki)
        {
            this.yetki = yetki;
            
        }
        public YetkiDenetimi()
        {
       
        }

        private  IMemoryCache _cache;
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var _userManager = context.HttpContext.RequestServices.GetService<UserManager<User>>();
            var appDbContext = context.HttpContext.RequestServices.GetService<appDbContext>();
            if (_cache == null)
                _cache = context.HttpContext.RequestServices.GetService<IMemoryCache>();

            if (context.HttpContext.Request.Headers.Any(c => c.Key == "Authorization"))
            {
                var tk = context.HttpContext.Request.Headers.FirstOrDefault(c => c.Key == "Authorization").Value.ToString().Split(" ")[1].Replace("\"","");
                List<RefreshToken> usertokens;

                if (_cache.Get("usertokens") == null)
                {
                    usertokens = appDbContext.RefreshToken.ToList();
                    _cache.Set("usertokens", JsonConvert.SerializeObject(usertokens), TimeSpan.FromMinutes(10));
                }
                else
                {
                    usertokens = JsonConvert.DeserializeObject<List<RefreshToken>>(_cache.Get("usertokens").ToString());

                    if (!usertokens.Any(c => c.Token == tk))
                    {
                        usertokens = appDbContext.RefreshToken.ToList();
                        _cache.Set("usertokens", JsonConvert.SerializeObject(usertokens), TimeSpan.FromMinutes(10));
                    }
                }
                var token = usertokens.FirstOrDefault(c => c.Token == tk);
                
                var user = _userManager.FindByIdAsync(token?.UserId.ToString()).Result;
                var roleId = appDbContext.UserRole.Where(x => x.UserId == user.Id).FirstOrDefault().RoleId;
                if (token != null && DateTime.Now < token.Expires && user != null)
                {
                    List<tempClaim> roleClaims;
                    if (_cache.Get("permissionsCache") == null)
                    {
                        roleClaims = appDbContext.RoleClaims.Where(c=> c.RoleId == roleId).Select(c => new tempClaim
                        {
                            Issuer = "LOCAL AUTHORITY",
                            Type = c.ClaimType,
                            Value = c.ClaimValue,
                            UserId = user.Id
                        }).ToList();

                        _cache.Set("permissionsCache", JsonConvert.SerializeObject(roleClaims), TimeSpan.FromMinutes(10));
                    }
                    else
                    {
                        roleClaims = JsonConvert.DeserializeObject<List<tempClaim>>(_cache.Get("permissionsCache").ToString());
                    }
                    var claims = roleClaims.Where(x =>
                       x.Type == CustomClaimTypes.Permission &&
                       x.Value == yetki &&
                       x.UserId == user.Id &&
                       x.Issuer == "LOCAL AUTHORITY"
                           )
                               .Select(c => new tempClaim
                               {
                                   Issuer = c.Issuer,
                                   Type = c.Type,
                                   Value = c.Value
                               })
                               .ToList();

                    if (string.IsNullOrEmpty(yetki) || claims.Any(x => x.Value == yetki))
                    {
                        token.Expires = DateTime.Now.AddHours(2);
                        token = appDbContext.RefreshToken.Find(token.Id);
                        appDbContext.RefreshToken.Update(token);

                        appDbContext.Entry(token).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        var lst = appDbContext.RefreshToken.Select(c => new { c.Id, c.Expires }).ToList();
                        lst = lst.Where(c => c.Expires < DateTime.Now).ToList();
                        var t = appDbContext.RefreshToken.Where(c => lst.Select(x => x.Id).Contains(c.Id));
                        appDbContext.RefreshToken.RemoveRange(t);
                        appDbContext.SaveChanges();

                        return;
                    }

                }
            }
            context.Result = new UnauthorizedObjectResult(HttpStatusCode.Unauthorized);
            return;
        }
    }
}
