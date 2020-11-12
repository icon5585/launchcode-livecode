using System;
using System.Collections.Generic;
using CodingEvents.Data;
using CodingEvents.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.events = EventData.GetAll();

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("/events/add")]
        //public IActionResult AddNewEvent(String name, String desc)
        public IActionResult AddNewEvent(Event newEvent) 
        {
            EventData.Add(newEvent);

            // Redirects back to the "events" index method above
            return Redirect("/events");
        }

        [HttpGet]
        public IActionResult Delete()
        {
            ViewBag.events = EventData.GetAll();

            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            foreach (int eventId in eventIds)
            {
                EventData.Remove(eventId);
            }

            return Redirect("/Events");
        }

    }
}
