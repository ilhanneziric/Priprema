using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Priprema.Services;
using Priprema.ViewModels;

namespace Priprema.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private readonly MovieDataContext context;
        public MovieController(MovieDataContext context)
        {
            this.context = context;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public List<MovieViewModel> Get()
        //{
        //    var movies = this.context.Movies.Include(m => m.Actors).Select(m => new MovieViewModel
        //    {
        //        Title = m.Title,
        //        Year = m.Year.ToString(),
        //        Summary = m.Summary,
        //        Actors = string.Join(',', m.Actors.Select(a => a.FullName))
        //    });

        //    return (List<MovieViewModel>)movies;
        //}

        [HttpGet]
        public List<Movie> GetAll()
        {
            var data = this.context.Movies.Include(s => s.Actors).ToList();
            return data;
        }
        //[HttpGet(Name = "GetWeatherForecast")]
        //public IActionResult Index()
        //{
        //    var movies = this.context.Movies.Include(m => m.Actors).Select(m => new MovieViewModel
        //    {
        //        Title = m.Title,
        //        Year = m.Year.ToString(),
        //        Summary = m.Summary,
        //        Actors = string.Join(',', m.Actors.Select(a => a.FullName))
        //    });

        //    return View(movies);
        //}
    }
}