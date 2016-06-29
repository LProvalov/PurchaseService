using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authorization;

namespace PurchaseService.Controllers
{
    [Authorize]
    public class HouseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}