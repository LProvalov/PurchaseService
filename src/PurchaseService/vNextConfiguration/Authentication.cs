using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Authentication.Cookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseService.vNextConfiguration
{
    internal static class Authentication
    {
        public static void ConfigureAuthentication(this IApplicationBuilder app)
        {
            //app.UseCookieAuthentication(new CookieAuthenticationOptions()
            //{
            //    LoginPath = "",
            //    CookieHttpOnly = true,
            //    AuthenticationScheme = "Cookies",
            //    AutomaticAuthenticate = true,
            //    AutomaticChallenge = true,
            //    Events = new CookieAuthenticationEvents()
            //    {
            //        OnRedirectToLogin = ctx =>
            //        {
            //            if (ctx.Request.Path.StartsWithSegments("/api") &&
            //            ctx.Response.StatusCode == 200)
            //            {
            //                ctx.Response.StatusCode = 401;
            //                return Task.FromResult<object>(null);
            //            }
            //            else
            //            {
            //                ctx.Response.Redirect(ctx.RedirectUri);
            //                return Task.FromResult<object>(null);
            //            }
            //        }
            //    }
            //});
        }
    }
}
