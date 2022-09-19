using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index1()
        {
            ViewBag.show = "Nitish Mehta";
            return View();
        }
    }
}
