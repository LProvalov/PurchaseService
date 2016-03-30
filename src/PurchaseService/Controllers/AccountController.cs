using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using PurchaseService.Models;
using System.Collections.Generic;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PurchaseService.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody]UserLogin user)
        {
            if (!string.IsNullOrWhiteSpace(user.UserName) && 
                !string.IsNullOrWhiteSpace(user.Password) && 
                user.Password.Equals(user.UserName))
            {
                List<Claim> claims = new List<Claim>()
                    {
                        new Claim("usr", user.UserName),
                        new Claim("access_token", "token")
                    };
                ClaimsIdentity identity = new ClaimsIdentity(claims, "local", "type", "role");
                await HttpContext.Authentication.SignInAsync("Cookies", new ClaimsPrincipal(identity));
            }
            return new JsonResult(new {
                Status = (int)HttpStatusCode.OK,
                Message = "logged in"
            });
        }
    }
}
