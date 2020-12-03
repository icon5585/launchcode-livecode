using System;

/**
 * LC 101 - Unit 2 
 * Class 2.18
 * Chapter 19 - Introduction to Object-Relational Mapping
 * Hank DeDona
 * 12/3/20
 */
namespace Class_2._18
{
    class Lecture
    {
        static void Main(string[] args)
        {
            // 19.1 Object-Relational Mapping
            // ORM is a way to convert/map C# objects to MySQL database entries

            // e.g. If we wanted to take this ContactInfo C# object and store it in MySQL using ORM

            // This:
            // public ContactInfo frank = new ContactInfo(3,"Frank","frank@email.com");

            // Becomes: 
            // INSERT INTO contactinfo (Id,Name,Email) VALUES(3, "Frank", "frank@email.com");

            // For this class, we'll be using EntityFrameworkCore as our C# ORM

            // 19.1.1 ORM in ASP.net

            // In order to connect our C# server to mysql, we need to update our appsettings.json with
            // a connection string that contains the server, userid, password and database to use!

            /*
            "ConnectionStrings": {
                "DefaultConnection": "server=localhost;userid=coding_events;password=PASSWORD;database=coding_events;"
            }
            */

            // 19.1.1.2.1.Install MySQL Dependency
            // The 2nd step to getting your C# server ORM ready is to get the NuGet package: Pomelo.EntityFrameworkCore.MySql
            // PLEASE NOTE: YOU MUST INSTALL ENTITY FRAMEWORK 3.1.x IN ORDER TO USE POMELO MYSQL!!!

            // 19.2 Accessing Data
            // Up to this point we have created a database, setup entity framework core .NET and set our connection, now lets use it!

            // For the remainder of this lecture, we will continue work on our coding events project (available in this github repository)

            // 19.2.2.1. Creating a DbContext
            // We need to create our own Database context in order to have getters/setters for our persisted data, in our example we'll
            // be creating one for events.

            // 19.2.2.2 Registering a data store
            // Once we create the database context/data store, we need to register it for use with Entity Framework Core .Net

            // We'll need to update our Startup.cs class (which is run at startup by C#.net)
            // public void ConfigureServices - Use this method to add services to the container

            // To register our db context using MySQL, we need to add the following to that method:
            // services.AddDbContext<EventDbContext>(options => options.UseMySql(Configuration.GetConnectionString("DefaultConnection")));

            // 19.2.2.3 Configuring a Primary Key
            // Entity Framework by default registers classes with properties called "ID" as their primary key!

            // 19.2.4 Migrations
            // We need to run a few tools in order to initialize and create our database tables
            // to use our C# objects

            // WARNING!
            // WE CAN ONLY INSTAL ENTITYFRAMEWORK VERSIONS 3.1.x, not 5.x
            // dotnet add package Microsoft.EntityFrameworkCore.Design --version=3.1.10
            // dotnet add package Microsoft.EntityFrameworkCore.Relational --version=3.1.10
            // dotnet add package Pomelo.EntityFrameworkCore.MySql

            // Once those packages are installed on our C# .csproj file as well our dotnet CLI
            // we can begin our DB setup.

            // 1) Initial migration
            // dotnet ef migrations add InitialMigration
            // This creates an table called __EFMigrationsHistory
            // This table keep track of migrations when new entity classes are added/updated/deleted
            // and keeps the DB tables and columns of those tables in sync via rows entered.

            // 2) Update database
            // dotnet ef database update
            // This creates the actual Events table for our C# entities
            // Notice that there's now an Events table :)

            // 19.3 Working with Data Stores
            // Querying
            // Get all events
            // dbContext.Events.ToList();

            // Find a single event by Id
            // dbContext.Events.Find(id);

            // Add a new event
            // dbContext.Events.Add(newEvent);
            // NOTE: Anytime the database context changes (add a new event, delete an event, update an event)
            // you must call SaveChanges() for it to actually persist. This allows you to run mutliple commands
            // at once.
            // dbContext.SaveChanges();

            // Delete an event
            // dbContext.Events.Remove(theEventToDelete);
            // Again, you must call dbContext.SaveChanges(); to delete it
        }

    }
}
