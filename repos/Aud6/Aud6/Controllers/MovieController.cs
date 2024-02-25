using Aud6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aud6.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie

        public static List<Movie> movies = new List<Movie>()
        {
            new Movie(){
            Name = "Shrek",
            Rating = 5,
            DownloadUrl = "test",
            ImageUrl = @"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQy4YOTGic5jNTl6joufz7jne7q_hvYMBYYWL3haFiy&s"
            },
            new Movie(){
            Name = "365 days",
            Rating = 4,
            DownloadUrl = "teddst",
            ImageUrl = @"https://static.wikia.nocookie.net/netflix/images/2/2b/365_Days_Don_Massimo_Torricelli_IB.jpg/revision/latest?cb=20220816044218"
            },
            new Movie()
            {
                Name = "Emily in Paris",
                Rating =8,
                DownloadUrl = "ffdfff",
                ImageUrl = @"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTWkwvpkDEFZNz-GjQRKdr0HiZHVPh17X-qDw&usqp=CAU"
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
            MovieRentals model =  new MovieRentals();
          
            model.movies = movies;
            return View(model);
        }
        public ActionResult ShowClient(int id)
        {
            var model = clients.ElementAt(id);
            return View(model);
        }
        public ActionResult Delete(int id) {
            movies.RemoveAt(id);
            return RedirectToAction("Random");
        }
        public ActionResult Edit(int id)
        {
            var model = movies.ElementAt(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if(ModelState.IsValid ==  false) {
                return View(movie);
            }
            else
            {
                var novmodel =  movies.ElementAt(movie.Id);
                novmodel.Id = movie.Id;
                novmodel.Name = movie.Name;
                novmodel.Rating = movie.Rating;
                return RedirectToAction("Random", movies);
            }
        }
        public ActionResult ShowMovie(int id)
        {
            var model = movies.ElementAt(id);
            return View(model);
        }e
    }
}