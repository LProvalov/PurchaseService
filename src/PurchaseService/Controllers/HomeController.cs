using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authorization;

namespace PurchaseService.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Result() {
            return Content("result");
        }
    }
}
