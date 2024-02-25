using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ucam.Models;

namespace ucam.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        List<EventModel> events = new List<EventModel>()
        {
            new EventModel()
            {
                Id = 1,
                Ime = "Sostanok",
                Lokacija = "Ohrid"
            },
            new EventModel()
            {
                Id = 2,
                Ime = "Aleksandar",
                Lokacija = "Struga"
            },
            new EventModel()
            {
                Id = 3,
                Ime = "Nikola",
                Lokacija = "Veles"
            }
        };
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowEvent()
        {
            return View(events);
        }
        public ActionResult NewElement()
        {
            var model = new EventModel();
            return View(model);
        }
        public ActionResult InsertNewElement(EventModel model) {
        if(ModelState.IsValid == false)
            {
                return View("NewElement",model);
            }
            else
            {
                events.Add(model);
                return View("ShowEvent",events);
            }
        
        }
    }
}