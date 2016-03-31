using Microsoft.AspNet.Mvc;
using PurchaseService.Models;
using Microsoft.AspNet.Authorization;


namespace PurchaseService.Controllers
{
    [Authorize]
    public class PersonController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var persons = new PersonDatabase();
            return View(persons);
        }
    }
}
