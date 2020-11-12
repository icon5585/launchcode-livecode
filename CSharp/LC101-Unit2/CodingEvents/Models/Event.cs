using System;
namespace CodingEvents.Models
{
    // This is a simple POCO with an event name
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int Id { get; }
        private static int nextId = 1;

        // In order to do model binding, a default constructor is required!
        public Event() { }

        public Event(String name, String description)
        {
            Name = name;
            Description = description;

            // Note: Normally the id assignment would be handled by a database
            Id = nextId;
            nextId++;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
