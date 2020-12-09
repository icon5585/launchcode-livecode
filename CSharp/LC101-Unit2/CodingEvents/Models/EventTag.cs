using System;
namespace CodingEvents.Models
{
    // 20.5.3 Many-to-many relationship class for events <--> tags
    public class EventTag
    {
        public int EventId { get; set; }
        public Event Event { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }

        public EventTag()
        {
        }
    }
}
