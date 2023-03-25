using Microsoft.AspNetCore.Mvc;
using MovieManager.Models;

namespace MovieManager.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieModel model;

        public MovieController(MovieModel model)
        {
            this.model = model;
        }
        /// <summary>
        /// Get Movies list of particular 'genre'.   
        /// </summary>
        /// <param name="genre"></param>
        /// <returns>
        /// Returns list of Movies of requested 'genre'
        /// </returns>
        public List<Movie> GetMovies(string genre)
        {
            return model.getMovies(genre);
        }
    }
}
