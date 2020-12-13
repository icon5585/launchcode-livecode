using CodingEvents.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CodingEvents.Data
{
    // 19.2.2.1 Your db context class must extend the entity framework core DbContext class
    public class EventDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCategory> Categories { get; set; }

        public DbSet<Tag> Tags { get; set; }

        // 20.5.3 EventTags dbcontext
        public DbSet<EventTag> EventTags { get; set; }

        public EventDbContext(DbContextOptions<EventDbContext> options)
              : base(options)
        { }

        // 20.5.3 Create a composite key on the EventTag table composed of EventId & TagId
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventTag>()
                .HasKey(e => new { e.EventId, e.TagId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
