using cineplex.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


//to navigate between the admin controller (could not fix a specific menu for the admin, so the options are /ManageMovies or /ManageActors or /AddEditMovies or /AddEditActors)
//the two last ones are accesible through the Manage pages
namespace cineplex.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Manage Movis and Actors

        public IActionResult ManageMovies()
        {
            var movies = MovieDataStore.Movies;

            return View(movies); 
        }
        public IActionResult ManageActors()
        {
            var actors = ActorDataStore.Actors; 
            return View(actors);
        }


        //Adding methods
        [HttpGet]
        public IActionResult AddEditMovie(string? name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                var movie = MovieDataStore.Movies.FirstOrDefault(m => m.Name == name);
                if (movie == null)
                {
                    return NotFound(); 
                }
                return View(movie);
            }

            return View(new Movie());
        }

        [HttpPost]
        public IActionResult AddEditMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                var existingMovie = MovieDataStore.Movies.FirstOrDefault(m => m.Name == movie.Name);

                if (existingMovie != null)
                {
                    existingMovie.Name = movie.Name;
                    existingMovie.PhotoUrl = movie.PhotoUrl;
                    existingMovie.Cinema = movie.Cinema;
                    existingMovie.Price = movie.Price;
                    existingMovie.Description = movie.Description;
                }
                else
                {
                    MovieDataStore.AddMovie(movie);
                }

                return RedirectToAction("ManageMovies");
            }

            return View(movie);
        }

        [HttpGet]
        public IActionResult AddEditActor(string? name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                var actor = ActorDataStore.Actors.FirstOrDefault(a => a.Name == name);
                if (actor == null)
                {
                    return NotFound();
                }
                return View(actor);
            }
            return View(new Actor());
        }

        [HttpPost]
        public IActionResult AddEditActor(Actor actor)
        {
            if (ModelState.IsValid)
            {
                var existingActor = ActorDataStore.Actors.FirstOrDefault(a => a.Name == actor.Name);

                if (existingActor != null)
                {
                    existingActor.PhotoUrl = actor.PhotoUrl;
                }
                else
                {
                    ActorDataStore.AddActor(actor);
                }

                return RedirectToAction("ManageActors");
            }

            return View(actor); 
        }


        [HttpPost]
        public IActionResult DeleteMovie(string name)
        {
            MovieDataStore.DeleteMovie(name); 
            return RedirectToAction("ManageMovies");
        }

        [HttpPost]
        public IActionResult DeleteActor(string name)
        {
            ActorDataStore.DeleteActor(name); 
            return RedirectToAction("ManageActors");
        }
    }
}
