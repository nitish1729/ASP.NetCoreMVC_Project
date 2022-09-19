using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("Nitish Mehta");
            return View();
        }
        public IActionResult navbar()
        {
            return View();
        }
        public IActionResult name()
        {
            Console.WriteLine("Nitish Mehta");
            return View();
           
        }
    }
}
