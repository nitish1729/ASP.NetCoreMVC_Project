﻿using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Hello()
        {
            return View();
        }
        public string Index()
        {
            return "Action method returning View";
        }
        public string Index1()
        {
            return "Hello World";
        }
        public string show()
        {
            return "Nitish Mehta";
        }
       

    }
}
