using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication23.Models;

namespace WebApplication23.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public static List<EventModel> events = new List<EventModel>
        {
            new EventModel(){Id = 3221, Ime = "sostanok", Lokacija = "Makedonija"},
            new EventModel(){Id = 2112, Ime = "seminar", Lokacija ="Srbija"},
            new EventModel(){Id = 3111, Ime = "miting", Lokacija = "Nigerija"}
        };
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult Random() // ova se pravi i mora vo view toa isto da se vika so ova
        {
            
            
          
          
            return View(events);
        }


    }
}