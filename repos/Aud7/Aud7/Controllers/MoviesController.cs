using Aud7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aud7.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movie
        public static Movie movie = new Movie()
        {
            Name = "Shrek",
            Rating = 5,
            DownloadUrl = "test",
            ImageUrl = @"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQy4YOTGic5jNTl6joufz7jne7q_hvYMBYYWL3haFiy&s"
        };
        public static List<Client> clients = new List<Client>()
        {
            new Client()
            {
                Name = "Aleksandar",
                ClenskaKarta = "123",
                Phone = "12212",
                Address = "Ruzveltova"
            },
            new Client()
            {
                Name = "viktor",
                ClenskaKarta = "23123",
                Phone = "12213232",
                Address = "Leninova"
            },
            new Client()
            {
                Name = "Stojce",
                ClenskaKarta = "111123",
                Phone = "122122222",
                Address = "Lonodnska"
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