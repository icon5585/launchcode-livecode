using System;
using System.Collections.Generic;
using System.Linq;
using CodingEvents.Data;
using CodingEvents.Models;
using CodingEvents.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodingEventsDemo.Controllers
{
    public class TagController : Controller
    {
        private EventDbContext dbContext;

        public TagController(EventDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Tag> tags = dbContext.Tags.ToList();
            return View(tags);
        }

        public IActionResult Add()
        {
            Tag tag = new Tag();
            return View(tag);
        }

        [HttpPost]
        public IActionResult Add(Tag tag)
        {
            if (ModelState.IsValid)
            {
                dbContext.Tags.Add(tag);
                dbContext.SaveChanges();
                return Redirect("/Tag/");
            }

            return View("Add", tag);
        }

        // responds to URLs like /Tag/AddEvent/5 (where 5 is an event ID)
        public IActionResult AddEvent(int id)
        {
            Event theEvent = dbContext.Events.Find(id);
            List<Tag> possibleTags = dbContext.Tags.ToList();
            AddEventTagViewModel viewModel = new AddEventTagViewModel(theEvent, possibleTags);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddEvent(AddEventTagViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

                int eventId = viewModel.EventId;
                int tagId = viewModel.TagId;

                List<EventTag> existingItems = dbContext.EventTags
                    .Where(et => et.EventId == eventId)
                    .Where(et => et.TagId == tagId)
                    .ToList();

                if (existingItems.Count == 0)
                {
                    EventTag eventTag = new EventTag
                    {
                        EventId = eventId,
                        TagId = tagId
                    };
                    dbContext.EventTags.Add(eventTag);
                    dbContext.SaveChanges();
                }

                return Redirect("/Events/Detail/" + eventId);
            }

            return View(viewModel);
        }

        public IActionResult Detail(int id)
        {
            List<EventTag> eventTags = dbContext.EventTags
                .Where(et => et.TagId == id)
                .Include(et => et.Event)
                .Include(et => et.Tag)
                .ToList();

            return View(eventTags);
        }

    }
}