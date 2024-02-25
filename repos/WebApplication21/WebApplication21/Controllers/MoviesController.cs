using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication21.Models;

namespace WebApplication21.Controllers
{
    public class MoviesController : Controller
    {
        public static Movie movie = new Movie()
        {
            Name = "Shrek", 
            Rating = 5,
            DownloadURL = "test",
            ImageUrl = @"https://www.looper.com/img/gallery/shrek-5-release-date-characters-and-plot-what-we-know-so-far/intro-1676959397.jpg"

        };
        public static List<Client> clients = new List<Client>()
        {
            new Client()
            {
                Name="Aleksandar", ClenskaKarta = "123", Phone = "554545",Address="nekoja adresa"
            },
            new Client()
            {
                Name="Test  ", ClenskaKarta = "555", Phone = "3333333",Address="Levinov"
            },
            new Client()
            {
                Name="Petko", ClenskaKarta = "444", Phone = "11111",Address="Ruzvelt"
            }

        };
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Random()
        {
            MovieRentals model = new MovieRentals();
            model.clients = clients;
            model.movie = movie;
            return View(model);
        }
    }
}