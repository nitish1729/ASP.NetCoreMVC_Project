using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string ? Name)
        {
            if (Name != null)
            {
                string MyName = Name;
            }
            
            // data transformimg from controller to views
            /*
             
            Console.WriteLine("Nitish Mehta");
            ViewData["Name"] = "Nitish Mehta";
            ViewBag.Name = "You will face many defeats in life, but never let yourself be defeated. - ...";
            TempData["Name"] = "Nitish Mehta, What should I learn before learning ASP.NET Core";

            */
            return View();
        }
        /*
        public IActionResult navbar()
        {
            return View();
        }
        public IActionResult name()
        {
            Console.WriteLine("Nitish Mehta");
            return View();
           
        }
        public IActionResult Welcome()
        {
            string Name = TempData["Name"].ToString();
            return View();
        }
        */
    }
}
