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
            List<Movie> moviesList;
            if (genre == String.Empty)
            {
                moviesList = context.Movies.ToList();
            }
            else
            {
                moviesList = context.Movies.Where(movie => movie.Genre == genre).ToList();
            }
            return moviesList;
        }
    }
}
