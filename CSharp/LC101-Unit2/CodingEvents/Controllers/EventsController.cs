using System;
using System.Collections.Generic;
using CodingEvents.Data;
using CodingEvents.Models;
using CodingEvents.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Event> events = new List<Event> (EventData.GetAll());

            // Passing in the events object to the view!
            return View(events);
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddEventViewModel addEventViewModel = new AddEventViewModel();

            // 15.1.4 Passing in the new view model to the View method returned to the user
            // this will then be mapped to the form in the view
            return View(addEventViewModel);
        }

        [HttpPost("/events/add")]
        public IActionResult AddNewEvent(AddEventViewModel addEventViewModel) 
        {
            // If all of the validation attributes are valid, create the event and store it
            if (ModelState.IsValid)
            {
                    // This is basically a line to convert an EventViewModel to an Event model object
                    Event newEvent = new Event {
                    Name = addEventViewModel.Name,
                    Description = addEventViewModel.Description,
                    ContactEmail = addEventViewModel.ContactEmail
                };

                EventData.Add(newEvent);

                // Redirects back to the "events" index method above
                return Redirect("/events");
            }

            // If there are validation errors, return the same view back with the provided values
            return View("Add", addEventViewModel);
        }

        [HttpGet]
        public IActionResult Delete()
        {
            ViewBag.events = EventData.GetAll();

            return View();
        }

        // /Events/Delete
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
