using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class FirstController : Controller
    {
        public string Index()
        {
            return "Hello World Wellcome to ASP.Net Core MVC 6";
        }
        public IActionResult Hello()
        {
            ViewBag.Message = "Hello World";
            return View();
        }
        public IActionResult Info()
        {
            Person person = new Person();
            person.Name = "Nitish Mehta";
            person.Age = 25;
            person.Location = "Bangalore";
            return View(person);
        }
    }
}
