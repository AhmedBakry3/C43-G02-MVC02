using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        //BaseUrl/Home/Index
        public IActionResult Index()
        {
            //return View("Ahmed" , new Movie()); //Return view with specific Name , //Take model to bind view with model data
            //return View("Ahmed"); //Return view with specific Name
            //return View( new Movie()); //Take model to bind view with model data
            return View(); //Return view of the same name of the action
        }

        //BaseUrl/Home/Privacy
        public IActionResult Privacy()
        {
            return View();
        }
        //BaseUrl/Home/AboutUs

        public IActionResult AboutUs()
        {
            return View();
        }

        //BaseUrl/Home/ContactUs
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
