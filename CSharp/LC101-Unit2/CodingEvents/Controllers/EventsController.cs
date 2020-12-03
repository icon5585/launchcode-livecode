using System.Linq;
using System.Collections.Generic;
using CodingEvents.Data;
using CodingEvents.Models;
using CodingEvents.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        private EventDbContext dbContext;

        // Dependency injection in C# - This is an example of IOC
        public EventsController(EventDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            // 19.3.2.2 Get the list of events from the dbcontext
            List<Event> events = dbContext.Events.ToList();

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

                // 19.3.2.2 Store (add) a new event to the DB
                dbContext.Events.Add(newEvent);
                dbContext.SaveChanges();

                // Redirects back to the "events" index method above
                return Redirect("/events");
            }

            // If there are validation errors, return the same view back with the provided values
            return View("Add", addEventViewModel);
        }

        [HttpGet]
        public IActionResult Delete()
        {
            ViewBag.events = dbContext.Events.ToList();

            return View();
        }

        // /Events/Delete
        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            // 19.3.2.2 Query (find) the event in the DB
            foreach (int eventId in eventIds)
            {
                Event theEventToDelete = dbContext.Events.Find(eventId);
                // 19.3.2.2 Delete the event from the DB
                // If it doesn't find it, it will return NULL
                if(theEventToDelete != null)
                {
                    dbContext.Events.Remove(theEventToDelete);
                }
            }

            dbContext.SaveChanges();

            return Redirect("/Events");
        }
    }
}
