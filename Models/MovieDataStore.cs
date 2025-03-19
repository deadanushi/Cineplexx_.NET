using System.Collections.Generic;
using System.Linq;

namespace cineplex.Models
{
    public static class MovieDataStore
    {
        public static List<Movie> Movies { get; set; } = new List<Movie>
        {
            new Movie
            {
                Name = "The Curse of La Llorona",
                Cinema = "Cinema QTU",
                Description = "When Patricia is found endangering the lives of her sons, Anna puts her behind bars. However, when Anna's own children are endangered, she suspects that there is more than human involvement at play.\r\n",
                Price = 10.50,
                PhotoUrl = "/Images/Movies/theCurse.jpeg",
                Actors = new List<Actor>
                {
                    new Actor { Name = "Chris Hemsworth", PhotoUrl = "/Images/Actors/cris.jpeg" },
                    new Actor { Name = "Robert Downey Jr.", PhotoUrl = "/Images/Actors/robert.jpeg" },
                    new Actor { Name = "Scarlett Johansson", PhotoUrl = "/Images/Actors/scarlet.jpeg" },

                }
            },
            new Movie
            {
                Name = "A Quiet Place: Day One",
                Cinema = "Cinema QTU",
                Description = "When New York City comes under attack from an alien invasion, a woman and other survivors try to find a way to safety. They soon learn that they must remain absolutely silent as the mysterious creatures are drawn to the slightest sound.\r\n",
                Price = 15.50,
                PhotoUrl = "/Images/Movies/QuietPlace.jpeg",
                Actors = new List<Actor>
                {
                    new Actor { Name = "Chris Hemsworth", PhotoUrl = "/Images/Actors/cris.jpeg" },
                    new Actor { Name = "Jennifer Lopez", PhotoUrl = "/Images/Actors/jlo.jpg" },
                }
            },
            new Movie
            {
                Name = "Extinction",
                Cinema = "Cinema TEG",
                Description = "After recurring nightmares of an alien invasion, Peter, an engineer, decides to seek psychiatric help. Soon, when his dreams translate into reality and UFOs attack Earth, he tries to save his family.\r\n",
                Price = 12.00,
                PhotoUrl = "/Images/Movies/Extc.jpeg",
                Actors = new List<Actor>
                {
                    new Actor { Name = "Jennifer Lopez", PhotoUrl = "/Images/Actors/jlo.jpg" },
                    new Actor { Name = "Chris Hemsworth", PhotoUrl = "/Images/Actors/cris.jpeg" },
                    new Actor { Name = "Scarlett Johansson", PhotoUrl = "/Images/Actors/scarlet.jpeg" },
                    new Actor { Name = "Robert Downey Jr", PhotoUrl = "/Images/Actors/robert.jpeg" },

                }
            },
            new Movie
            {
                Name = "Gladiator",
                Cinema = "Cinema QTU",
                Description = "Years after witnessing the death of Maximus at the hands of his uncle, Lucius must enter the Colosseum after the powerful emperors of Rome conquer his home. With rage in his heart and the future of the empire at stake, he looks to the past to find the strength and honor needed to return the glory of Rome to its people.\r\n",
                Price = 15.00,
                PhotoUrl = "/Images/Movies/gladi.jpeg",
                Actors = new List<Actor>
                {
                    new Actor { Name = "Chris Hemsworth", PhotoUrl = "/Images/Actors/cris.jpeg" },
                    new Actor { Name = "Robert Downey Jr", PhotoUrl = "/Images/Actors/robert.jpeg" },
            new Actor { Name = "Chris Hemsworth", PhotoUrl = "/Images/Actors/robert.jpeg" }

                }
            },
            new Movie
            {
                Name = "Gladiator",
                Cinema = "Cinema TEG",
                Description = "Years after witnessing the death of Maximus at the hands of his uncle, Lucius must enter the Colosseum after the powerful emperors of Rome conquer his home. With rage in his heart and the future of the empire at stake, he looks to the past to find the strength and honor needed to return the glory of Rome to its people.\r\n",
                Price = 15.00,
                PhotoUrl = "/Images/Movies/gladi.jpeg",
                Actors = new List<Actor>
                {
                       new Actor { Name = "Chris Hemsworth", PhotoUrl = "/Images/Actors/cris.jpeg" },
                    new Actor { Name = "Robert Downey Jr", PhotoUrl = "/Images/Actors/robert.jpeg" },
            new Actor { Name = "Robert Downey Jr", PhotoUrl = "/Images/Actors/robert.jpeg" }
                }
            },
            new Movie
            {
                Name = "Back in Action",
                Cinema = "Cinema QTU",
                Description = "Former CIA spies Emily and Matt are pulled back into espionage after their secret identities are exposed.\r\n",
                Price = 10.50,
                PhotoUrl = "/Images/Movies/backIa.jpeg",
                Actors = new List<Actor>
                {
                       new Actor { Name = "Chris Hemsworth", PhotoUrl = "/Images/Actors/cris.jpeg" },
                    new Actor { Name = "Robert Downey Jr", PhotoUrl = "/Images/Actors/robert.jpeg" },
            new Actor { Name = "Scarlett Johansson", PhotoUrl = "/Images/Actors/scarlet.jpeg" }
                }
            },
            new Movie
            {
                Name = "The Fall Guy",
                Cinema = "Cinema TEG",
                Description = "After leaving the business one year earlier, battle-scarred stuntman Colt Seavers springs back into action when the star of a big studio movie suddenly disappears. As the mystery surrounding the missing actor deepens, Colt soon finds himself ensnared in a sinister plot that pushes him to the edge of a fall more dangerous than any stunt.\r\n",
                Price = 10.50,
                PhotoUrl = "/Images/Movies/theFall.jpeg",
                Actors = new List<Actor>
                {
                      new Actor { Name = "Jennifer Lopez", PhotoUrl = "/Images/Actors/jlo.jpg" },
                    new Actor { Name = "Scarlett Johansson", PhotoUrl = "/Images/Actors/scarlet.jpeg" },
            new Actor { Name = "Robert Downey Jr", PhotoUrl = "/Images/Actors/robert.jpeg" }
                }
            }
        };

        public static void AddMovie(Movie movie)
        {
            Movies.Add(movie);
        }
        public static void UpdateMovie(Movie updatedMovie)
        {
            var movie = Movies.FirstOrDefault(m => m.Name == updatedMovie.Name);
            if (movie != null)
            {
                movie.Name = updatedMovie.Name;
                movie.Cinema = updatedMovie.Cinema;
                movie.Description = updatedMovie.Description;
                movie.Price = updatedMovie.Price;
                movie.PhotoUrl = updatedMovie.PhotoUrl;
            }
        }
        public static void DeleteMovie(string name)
        {
            var movie = Movies.FirstOrDefault(m => m.Name == name);
            if (movie != null)
            {
                Movies.Remove(movie);
            }
        }

        public static List<Movie> GetMoviesByCinema(string cinemaName)
        {
            return Movies.Where(m => m.Cinema == cinemaName).ToList();
        }
    }
}
