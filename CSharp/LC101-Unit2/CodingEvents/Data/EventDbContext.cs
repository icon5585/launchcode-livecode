using CodingEvents.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingEvents.Data
{
    // 19.2.2.1 Your db context class must extend the entity framework core DbContext class
    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public EventDbContext(DbContextOptions<EventDbContext> options)
              : base(options)
        { }
    }
}
