using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authorization;

namespace PurchaseService.Controllers
{
    [Authorize]
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}