using Microsoft.AspNetCore.Mvc;
using MovieManager.Models;

namespace MovieManager.Controllers
{
    public class MovieController : Controller
    {
        public Movie GetMovies(string genre)
        {
            return new Movie();
        }
    }
}
