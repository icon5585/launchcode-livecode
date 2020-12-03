namespace CodingEvents.Models
{
    // This is a simple POCO with an event name
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }


        // 19.2.2.3 Configuring a primary key
        // Any properties named ID will automatically be used as a primary key
        // by the Entity Framework. This will automatically be set by the DB.
        public int Id { get; set; }

        // In order to do model binding, a default constructor is required!
        public Event() {}

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
