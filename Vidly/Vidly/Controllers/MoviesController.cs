using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            Movies movies = new Movies() {Title="Amad Khan" };
             return View(movies);
            /*
            return Content("amad khan g");
            return RedirectToAction("Index", "Home",new { page = "1", sortBy ="amad"});
            */
        }
        public IActionResult Edit(int id) {
        
            return Content("id="+ id);
        }public IActionResult Index(int? pageNO,String sortBy) {
        
            return Content(String.Format("page No is {0} ,sortby is {1} ",pageNO,sortBy));
        }

    }
}
