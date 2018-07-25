using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        
        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

      
        public ActionResult Details(int id)
        {
            var movie = GetMovies().FirstOrDefault(c => c.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            return View( movie );
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie() {Id = 1, Name = "Movie 1"},
                new Movie() {Id = 2, Name = "Movie 2"}
            };
        }

        
    }
}