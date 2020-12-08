using System;
using System.Collections.Generic;

namespace CodingEvents.Models
{
    public class EventCategory
    {
        public string Name { get; set; }

        public int Id { get; set; }

        // Other 1/2 of one-to-many relationship
        // i.e. One event category can have many events
        public List<Event> Events { get; set; }

        public EventCategory(string name)
        {
            Name = name;
        }

        public EventCategory()
        {
        }
    }
}