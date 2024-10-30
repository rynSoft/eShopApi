
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace eShopApi.Auth
{
    public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement>
    {   
        private IHttpContextAccessor http;
        public PermissionAuthorizationHandler(
           
            IHttpContextAccessor http
            )
        {
            this.http = http;
     
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
        {
            if (http.HttpContext.Request.Headers.Any(c => c.Key == "Authorization"))
            {
                var tk = http.HttpContext.Request.Headers.FirstOrDefault(c => c.Key == "Authorization").Value.ToString().Split(' ')[1];
                //var token = appDbContext.UserTokens.FirstOrDefault(c => c.Token == tk);
                //if (token != null && DateTime.Now < token.Exp)
                //{
                //    var UserID = token.UserId;
                //    if (_userManager.FindByIdAsync(UserID) != null)
                //    {
                //        var user = await _userManager.FindByIdAsync(UserID);
                //        if (user == null)
                //        {
                //            return;

                //        }
                //        var userClaims = await _userManager.GetClaimsAsync(user);
                //        var permissions = userClaims.Where(x => x.Type == CustomClaimTypes.Permission &&
                //                                    x.Value == requirement.Permission &&
                //                                    x.Issuer == "LOCAL AUTHORITY")
                //                        .Select(x => x.Value);
                //        if (permissions.Any())
                //        {
                //            token.Exp = DateTime.Now.AddMinutes(10);
                //            //appDbContext.Entry(token).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                //            //appDbContext.SaveChanges();
                //            context.Succeed(requirement);
                //            return;
                //        }
                //    }
                //}
            }
            return;
        }
    }
}
