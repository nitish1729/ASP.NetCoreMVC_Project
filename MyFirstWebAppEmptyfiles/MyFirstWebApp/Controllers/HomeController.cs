using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            //Console.WriteLine("Nitish Mehta");
            //ViewData["Name"] = "Nitish Mehta";
            ViewBag.Name = "You will face many defeats in life, but never let yourself be defeated. - ...";
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
