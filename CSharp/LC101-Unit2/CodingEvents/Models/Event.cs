using System;
using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Models
{
    // This is a simple POCO with an event name
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }

        public int Id { get; }
        private static int nextId = 1;

        // In order to do model binding, a default constructor is required!
        public Event() {
            Id = nextId;
            nextId++;
        }

        public Event(string name, string description, string contactEmail) : this()
        {
            Name = name;
            Description = description;
            ContactEmail = contactEmail;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
