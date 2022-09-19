using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index1()
        {
            return View();
        }
    }
}
