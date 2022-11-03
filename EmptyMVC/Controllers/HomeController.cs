using Microsoft.AspNetCore.Mvc;

namespace EmptyMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
