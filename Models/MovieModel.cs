namespace MovieManager.Models
{
    public class MovieModel
    {
        private readonly AppDbContext context;

        public MovieModel(AppDbContext context)
        {
            this.context = context;
        }

        public List<Movie> getMovies(string genre)
        {
            return context.Movies.Where(movie => movie.Genre == genre).ToList();
        }
    }
}
