using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication26.Models;

namespace WebApplication26.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public static List<Movie> movies  = new List<Movie>()
        {
            new Movie()
            {
            Name = "Shrek",
            Rating = 5,
            DownloadUrl = "test",
            ImageUrl = @"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTa0oWIx2w06HMjC71KTDKW4a7DqeiIC2rIaiPJLXN43g&s"
        }
        };
        public static List<Client> clients = new List<Client>()
        {
           
        };
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Random()
        {
            MovieRentals model = new MovieRentals();
            model.clients = clients;
            model.movie = movies.ElementAt(0);
            return View(model);
        }
        public ActionResult ShowClient(int id)
        {
            var model = clients.ElementAt(id);
            return View(model);
        }
        public ActionResult GetAllMovies() { 
        return View(movies);
        }
        public ActionResult NewMovie()
        {
            Movie model = new Movie();  
            return View(model); 
        }
        public ActionResult InsertNewMovie(Movie model)
        {
            if(ModelState.IsValid == false) {
                return View("NewMovie", model);
            }
            else
            {
                movies.Add(model);
                return View("GetAllMovies", movies);
            }
            
        }
    }
}