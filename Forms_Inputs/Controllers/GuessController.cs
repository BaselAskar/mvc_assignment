using Forms_Inputs.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Forms_Inputs.Controllers
{
    public class GuessController : Controller
    {
        public IActionResult Index()
        {
            string? rn_string = Request.Cookies["secret"];

            if (rn_string == null)
            {
                CookieOptions options = new CookieOptions();
                options.Expires = DateTimeOffset.UtcNow.AddMinutes(1);

                Random random = new Random();

                int randomNumber = random.Next(1, 100);

                Response.Cookies.Append("secret", randomNumber.ToString(), options);


            }



            return View();
        }



        [HttpPost]
        public IActionResult Index(int number)
        {
            string? rn_string = Request.Cookies["secret"];

            int secretNumber;

            if (rn_string == null)
            {
                CookieOptions options = new CookieOptions();
                options.Expires = DateTimeOffset.UtcNow.AddMinutes(1);

                Random random = new Random();

                int randomNumber = random.Next(1, 100);

                Response.Cookies.Append("secret", randomNumber.ToString(), options);

                secretNumber = randomNumber;
            }
            else
            {
                secretNumber = int.Parse(rn_string);
            }


            ViewBag.Message = Result.Guessing(number, secretNumber);

            return View();
        }
    }
}
