using Asp.NetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreMVC.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Infor()
        {
            Student st = new Student();
            st.StudentID = 27;
            st.Name = "Tejas";
            st.Gender = 'M';
            st.Branch = "PCM";
            st.Section = "A";
            return View(st);
        }
    }
}
