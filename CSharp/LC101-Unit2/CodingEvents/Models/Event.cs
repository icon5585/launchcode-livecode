using System;
using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Models
{
    // This is a simple POCO with an event name
    public class Event
    {
        [FromForm(Name = "name")]
        public string Name { get; set; }
        [FromForm(Name = "description")]
        public string Description { get; set; }

        public int Id { get; }
        private static int nextId = 1;

        // In order to do model binding, a default constructor is required!
        public Event() {
            Id = nextId;
            nextId++;
        }

        public Event(String name, String description) : this()
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
