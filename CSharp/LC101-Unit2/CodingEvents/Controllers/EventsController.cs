using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        // Note: We are using this static list as a jank datastore :P
        // It will be reset everytime we restart our web server
        static private List<String> Events = new List<string>();

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.events = Events;

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("/events/add")]
        // Note: the string parameter "name" matches the name of the form element
        public IActionResult AddNewEvent(String name)
        {
            Events.Add(name);

            // Redirects back to the "events" index method above
            return Redirect("/events");
        }
    }
}
