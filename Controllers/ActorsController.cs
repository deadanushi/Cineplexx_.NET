using cineplex.Models;
using Microsoft.AspNetCore.Mvc;

public class ActorsController : Controller
{
    public IActionResult Index()
    {
        var actors = ActorDataStore.Actors;
        return View(actors);
    }
}
