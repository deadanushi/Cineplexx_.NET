namespace cineplex.Models
{
	public class Movie
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public string PhotoUrl { get; set; }
		public string Cinema {  get; set; }
		public List<Actor> Actors { get; set; }

	}
}
