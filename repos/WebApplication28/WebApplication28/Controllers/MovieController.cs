using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication28.Models;

namespace WebApplication28.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public static Movie movie = new Movie()
        {
            Name = "Shrek",
            Rating = 5,
            DownloadUrl = "test",
            ImageUrl =  @"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTa0oWIx2w06HMjC71KTDKW4a7DqeiIC2rIaiPJLXN43g&s"
        };
        public static List<Client> clients = new List<Client>()
        {
            new Client()
            {
                Name = "Viktor",
                ClenskaKarta = "123",
                Age = 5,

                Phone = "50405403",
                Address = "Ruzvleotva"
            },
             new Client()
            {
                Name = "Aleksandar",
                ClenskaKarta = "1323",
                Age = 50,
                Phone = "504432433",
                Address = "Leninova"
            }
        };

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Random() // za da se prikazat filmovite  i tie so rentet
        {
            MovieRentals model = new MovieRentals();
            model.clients = clients;
            model.movie = movie;
            return View(model);
        }
        public ActionResult ShowClient(int id) // za da se prikazat podatoci pri klikanje na imeto na klientot
        {
            var model =  clients.ElementAt(id);
            return View(model);
        }
    }
}