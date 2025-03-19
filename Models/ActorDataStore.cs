using System.Collections.Generic;
using System.Linq;

namespace cineplex.Models
{
    public static class ActorDataStore
    {
        private static List<Actor> _actors = new List<Actor>
        {
            new Actor { Name = "Robert Downey Jr.", PhotoUrl = "/Images/Actors/robert.jpeg" },
            new Actor { Name = "Scarlett Johansson", PhotoUrl = "/Images/Actors/scarlet.jpeg" },
            new Actor { Name = "Chris Hemsworth", PhotoUrl = "/Images/Actors/cris.jpeg" },
            new Actor { Name = "Jennifer Lopez", PhotoUrl = "/Images/Actors/jlo.jpg" }
        };

        public static IEnumerable<Actor> Actors => _actors;

        public static void AddActor(Actor actor)
        {
            if (actor != null && !_actors.Any(a => a.Name == actor.Name))
            {
                _actors.Add(actor);
            }
        }

        public static void UpdateActor(Actor updatedActor)
        {
            var actor = _actors.FirstOrDefault(a => a.Name == updatedActor.Name);
            if (actor != null)
            {
                actor.Name = updatedActor.Name;
                actor.PhotoUrl = updatedActor.PhotoUrl; 
            }
        }

        public static void DeleteActor(string name)
        {
            var actor = _actors.FirstOrDefault(a => a.Name == name);
            if (actor != null)
            {
                _actors.Remove(actor);
            }
        }
    }
}
