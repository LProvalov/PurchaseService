using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authorization;

namespace PurchaseService.Controllers
{
    
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Result() {
            return Content("result");
        }
    }
}
