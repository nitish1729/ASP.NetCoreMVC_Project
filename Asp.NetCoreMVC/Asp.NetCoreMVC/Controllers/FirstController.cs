using Asp.NetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreMVC.Controllers
{
    public class FirstController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }

        public IActionResult Hello()
        {
            ViewBag.Message = "Hello World Wellcome to the ASP.Net Core MVC ";
            return View();
        }
        public IActionResult info()
        {
            Person person = new Person();
            person.FirstName = "Nitish";
            person.LastName = " Mehta";
            person.FullName = person.FirstName + " " + person.LastName;
            person.age = 25;
            person.city = "Bangalore";
            return View(person);
        }
    }
}
