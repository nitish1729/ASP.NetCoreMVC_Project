using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index1()
        {
            // data transformimg from controller to views
            ViewBag.show = "Nitish Mehta";
            return View();
        }
    }
}
