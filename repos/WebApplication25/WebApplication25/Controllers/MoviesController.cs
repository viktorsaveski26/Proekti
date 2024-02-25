using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using WebApplication25.Models;

namespace WebApplication25.Controllers
{
    public class MoviesController : Controller
    {
        public static Movie movie = new Movie()
        {
            Name = "Shrek",
            rating = 1,
            DownloadUrl ="test",


        };
        public static List<Client> clients = new List<Client> { 
        new Client()
        {
            Name = "Viktor",ClenskaKarta = "123", Age = 29,Phone = "07542332", Address = "londonska"
        },
          new Client()  {
                Name = "petre",ClenskaKarta = "113",Age = 7, Phone = "073234332", Address = "varsavska"

        },
           new Client()  {
                Name = "pero",ClenskaKarta = "213", Age = 10,Phone = "07343444332", Address = "ruzveltova"

        }
        };
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Random() // ova se pravi i mora vo view toa isto da se vika so ova
        {
            MovieRentals model = new MovieRentals();
            model.clients = clients;
            model.movie = movie;
            return View(model);
        }
        public ActionResult ShowClient(int id)
        {
            var model = clients.ElementAt(id); 
            return View(model);
        }
    }
}