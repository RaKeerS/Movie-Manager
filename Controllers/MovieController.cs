using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MovieManager.Models;
using NSwag.Annotations;

namespace MovieManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [OpenApiTag("Movie", Description = "Movies management.")]
    public class MovieController : Controller
    {
        private readonly MovieModel model;

        public MovieController(MovieModel model)
        {
            this.model = model;
        }

        /// <summary>
        ///     Get Movies list of particular 'genre'.   
        /// </summary>
        /// <param name="genre"> Optional parameter, if sent as an Empty string will return a list of all Movies </param>
        /// <returns>
        ///     Returns list of Movies of requested 'genre'
        /// </returns>
        /// <response code="200">Successful operation</response>
        /// <response code="204">No record found</response>
        [HttpGet("GetMovies")]
        [SwaggerResponse(HttpStatusCode.OK, typeof(Movie), Description = "Successful operation")]
        [SwaggerResponse(HttpStatusCode.NoContent, null, Description = "No record found")]
        public ActionResult<List<Movie>> GetMovies([BindRequired][FromQuery]string genre)
        {
            List<Movie> moviesList = model.getMovies(genre);
            if (moviesList.Count == 0) 
            {
                return NoContent();
            }
            else
            {
                return Ok(moviesList);
            }
        }
    }
}
