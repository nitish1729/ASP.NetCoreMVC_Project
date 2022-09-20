using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class PostMethodController : Controller
    {
        public IActionResult PostMethodData()
        {
            return View();
        }
        [HttpPost]
        
        public IActionResult PostMethodData(string Email_Id, string Password,string Present_Address, string Residential_Address, string City, string State, int Zip)
        {
            string MyemailId = Email_Id;
            string MyPassword = Password;
            string PAddress = Present_Address;
            string RAddress = Residential_Address;
            string MyCity = City;
            string MyState = State;
            int ZipCode = Zip;

            return View();
        }

        /*
        public IActionResult Postmethod(string Email_Id, string Password, string Present_Address, string Residential_Address, string City, string State, int Zip)
        {
            string MyemailId = Email_Id;
            string MyPassword = Password;
            string PAddress = Present_Address;
            string RAddress = Residential_Address;
            string MyCity = City;
            string MyState = State;
            int ZipCode = Zip;

            return View("PostMethodData");
           
        }
        */
    }
}
