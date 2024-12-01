using Microsoft.AspNetCore.Mvc;

namespace eDziennik.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy() //test
        {
            return View();
        }
    }
}
