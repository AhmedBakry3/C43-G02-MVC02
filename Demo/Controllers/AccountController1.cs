using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class AccountController1 : Controller
    {
        //BaseURL/Account/SignUp
        public IActionResult SignUp()
        {
            return View();
        }
        //BaseURL/Account/Register
        public IActionResult Register()
        {
            return View();
        }
    }
}
