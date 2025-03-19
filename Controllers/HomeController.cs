using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace cineplex.Controllers
{
    public class HomeController : Controller
    {
        //for the admins
        public IActionResult Login()
        {
                if (User.IsInRole("Admin"))
                    return RedirectToAction("Index", "Admin");
            

            return View(); 
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                HttpContext.Session.SetString("Username", username);

                return RedirectToAction("Index", "Admin");
            }

            ViewBag.ErrorMessage = "Invalid admin credentials.";
            return View("Login");
        }


        //For the users
        [HttpPost]
        public IActionResult UserAccess()
        {
            return RedirectToAction("Homepage", "Home");
        }

        public IActionResult HomePage()
        {
            return View();
        }
    }
}
