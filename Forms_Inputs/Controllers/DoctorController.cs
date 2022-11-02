using Forms_Inputs.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Forms_Inputs.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult TestFever()
        {
            return View();
        }


        [HttpPost]
        public IActionResult TestFever(double temp)
        {
            if (temp == 0)
            {
                ViewBag.Message = "Place insert the degree";
            }
            else
            {
                ViewBag.Message = FeverResult.Test(temp);
            }

            return View();
        }
    }
}
