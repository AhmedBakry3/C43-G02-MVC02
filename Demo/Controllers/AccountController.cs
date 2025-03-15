using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class AccountController : Controller
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
