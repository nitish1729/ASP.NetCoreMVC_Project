using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class PostMethodController : Controller
    {
        public IActionResult PostMethodData()
        {
            return View();
        }
    }
}
