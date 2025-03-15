using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class MoviesController : Controller
    {
        ////BaseUrl/Movies/DeleteMovie
        //[NonAction]
        //public void DeleteMovie() { }
        //BaseUrl/Movies/Index
        public string Index()
        {
            return "Hello From Index";
        }

        ////BaseUrl/Movies/GetMovie/10?name=Batman(If you didnt write name in pattern) 
        ////BaseUrl/Movies/GetMovie/?id=10&name=Batman (If you didnt write id & name in pattern)
        ////[HttpPost] //the Method is Get By default (You can change it by Postman)
        //[HttpGet]
        //public void GetMovie(int? id, string name)
        //{

        //}

        #region Actions

        #region Example1
        //[HttpGet]
        //public ContentResult GetMovie(int? id, string name)
        //{
        //    //ContentResult Result = new ContentResult();
        //    //Result.Content = $"Movie with Name ={name} <br> with Id ={id}";
        //    //Result.ContentType="text/html";
        //    //Result.StatusCode = 700;
        //    //return Result;
        //    //return Content($"Movie with Name ={name} <br> with Id ={id}" , "text/html");


        //    //return $"Movie with Name ={name} and with Id ={id}"; // [/text/plain]
        //} 
        #endregion

        #region Example2

        //[HttpGet]
        //public IActionResult GetMovie(int? id, string name)
        //{
        //    //id = 0 => bad request
        //    //id<10 => not found
        //    //id>10 => return movie
        //    if (id == 0)
        //        return BadRequest();
        //    else if (id < 10)
        //        return NotFound();
        //    return Content($"Movie with Name ={name} <br> with Id ={id}", "text/html");
        //}
        #endregion

        #region Example3

        //public IActionResult TestReDirectAction()
        //{
        //    return RedirectToRoute("Default", new { controller = "Movies", Action = "GetMovie", id = 10 });
        //    //return RedirectToAction(nameof(GetMovie) , "Movies" , new { id = 10 , name = "test"});
        //    //return Redirect("https://localhost:44349/Movies/GetMovie/10");
        //    //return Redirect("https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/controllers-and-routing/aspnet-mvc-controllers-overview-cs#understanding-action-results");
        //}
        #endregion
        #endregion

        #region Model Binding

        #region Simple Data
        //[HttpPost]
        //public IActionResult TestModelBinding([FromQuery] int? id, string name)
        //{
        //    return Content($"Your Movie is {name} and your id is {id}");
        //}
        #endregion

        #region Complex Data

        [HttpPost]
        //public IActionResult AddMovie([FromHeader] Movie movie) //FromHeader is not working for Complex Data
        //{
        //    if (movie is null)
        //        return BadRequest();
        //    else 
        //    return Content($"Your Movie is {movie.Name} and your id is {movie.Id}");
        //}

        //[HttpGet]
        //public IActionResult AddMovie(Movie movie)
        //{
        //if (movie is null)
        //     return BadRequest();
        // else 
        //    return Content($"Your Movie is {movie.Name} and your id is {movie.Id}");
        //}
        #endregion

        #region Collection Data

        [HttpGet]
        public IActionResult TestModelBinding(int[] arr)
        {
            return Content("");
        }
        #endregion

        #region Mixed Data

        //[HttpGet]
        //public IActionResult AddMovie(int? id , string name , Movie movie)
        //{
        ///if (movie is null)
        //     return BadRequest();
        // else 
        //    return Content("");
        //}


        [HttpGet]
        public IActionResult AddMovie(int? id, string name, Movie movie , int[] arr)
        {
        if (movie is null)
                return BadRequest();
            else
                return Content("");
        }
        #endregion

        #endregion



    }
}
