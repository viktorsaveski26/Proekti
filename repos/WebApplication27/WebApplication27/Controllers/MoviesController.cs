using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using WebApplication27.Models;

namespace WebApplication27.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public static Movie movie = new Movie()
        {
            Id = 1,
            Name="Shrek",
            Rating = 5,
            DownloadUrl="test",
            ImageUrl = @"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTa0oWIx2w06HMjC71KTDKW4a7DqeiIC2rIaiPJLXN43g&s"
        };
        public static List<Client> clients = new List<Client>()
        {
            new Client()
            {
                Name = "Pece",
                ClenskaKarta = "123",
                Phone = "06434345",
                Address = "Ruzveltova"
            },
             new Client()
            {
                Name = "Viktor",
                ClenskaKarta = "1434343223",
                Phone = "064332324345",
                Address = "Lonodnska"
            }

        };
        public ActionResult Index()
        {
            return View();
        }

        public List<pupils> getAllPupilsFromClas3(orgId, classId, teacherID)
        {
                                    

        }
        public List<upilss> Random(string orgId,string classId,string teacherIDi)
        {
            var responseData = Htsdf.Movie.find(movieID);
            var getdata = DBNull.moir.find response.id
            if(responseData != null) { return View(responseData); }
            getdata.name = "jonce"
                db.save();
            return new List<Pupilsss>();

            //MovieRentals model = new MovieRentals();
            //model.clients = clients;
            //model.movie = movie;
            //    return View(model);
        }
    }
}