using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videos4You.Models;
using System.Data.Entity;
using Videos4You.ViewModels;

namespace Videos4You.Controllers
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        
        [Route("movies/index")]
        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genres).ToList();
            

            return View(movies);
        }


        public ActionResult New()
        {

            var genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Movie = new Movie(),
                Genres = genres
            };

            return View("MovieForm",viewModel);
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound("That movie does not exist!");

            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }

        [Route("movies/index/details/{id}")]
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound("That movie does not exist!");

            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };

            return View("Details", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {

            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel
                {
                    Movie= movie,
                    Genres = _context.Genres.ToList()
                };
                return View("MovieForm", viewModel);
            }

            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.Released = movie.Released;
                movieInDb.DurationInMinutes = movie.DurationInMinutes;
                movieInDb.Description = movie.Description;
                movieInDb.TimesRented = movie.TimesRented;
                movieInDb.InStock = movie.InStock;
                movieInDb.GenresId = movie.GenresId;
                movieInDb.DateAdded = movie.DateAdded;

            }

            
             _context.SaveChanges();
            

            return RedirectToAction("Index", "Movies");
        }
    }
}