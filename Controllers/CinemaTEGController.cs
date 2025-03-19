using cineplex.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace cineplex.Controllers
{
    public class CinemaTEGController : Controller
    {
        public IActionResult Index()
        {
            var movies = MovieDataStore.GetMoviesByCinema("Cinema TEG");
            return View(movies);
        }

        public IActionResult Details(string name)
        {
            var movie = MovieDataStore.Movies.FirstOrDefault(m => m.Name.Equals(name) && m.Cinema == "Cinema TEG");

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }
    }
}
