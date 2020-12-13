using System;

/**
 * LC 101 - Unit 2 
 * Class 2.19
 * Chapter 20 - Relationships in Object-Relational Mapping
 * Hank DeDona
 * 12/8/20 & 12/10/20
 */
namespace Class_2._19
{
    class Lecture
    {
        static void Main(string[] args)
        {
            // 20.1 Types of relationships
            // In previous lectures we discussed the different types of relationships
            // that we could represent in relational databases, including:
            // One-to-one
            // One-to-many
            // Many-to-many

            // 20.1.1 One-to-one
            // While relationships in SQL are bidirectional, relationships in programming languages are unidirectional.
            // In other words, if A knows about B, then B doesn’t necessarily know about A.

            // e.g. While we could store event and event details on separate tables with the following data:
            // Event - Name
            // EventDetails - Description & contactEmail

            // The object (POCO) Event has all of the data in the same class, this would be an example of a
            // unidirectional one-to-one relationship.

            // 20.1.2 One-to-Many and Many-to-One
            // A one-to-many relationship occurs when each instance of type A may be related to more than one instance of type B,
            // but each instance of B can only be related to a single instance of type A.

            // e.g. A single event category can have many events
            // EventCategory - Name
            // Event - Name1
            // Event - Name2
            // ...

            // Note: The same example can be used to represent the reciprocal, or the many-to-one relationship

            // 20.1.3 Many-to-Many
            // Many-to-many relationships occur when each instance of type A can be related to multiple instances of type B,
            // and vice versa.

            // e.g. Many events can have many tags
            // Event - Name1
            // Event - Name2
            // Tag - Name1
            // Tag - Name2
            // These can all be related to each other using a many-to-many relationship

            // 20.2 A primer on Lambda Expressions
            // A lambda expression is an inline function defined using the symbol =>
            // e.g. argument => return expression

            // 20.2.1 Select Example
            // The Select method takes a lambda expression as a parameter.
            // e.g. nums.Select(x => 2 * x);

            // How to explain: The Lambda here iterates over the numbers in the array nums
            // and puts each iterations value in the variable x.
            // A way to say this is in the Lambda for values of X in nums => do stuff

            // In this example we are taking each value in the array nums, setting it to x,
            // and then returning 2 * x (double it), and storing it in a new array.

            // Think of it as a shorthand for a for-each loop that stores each return value in a new array

            LambdaExampleClass.SelectExample();

            // This method does the same thing as the Lambda select with a for-each (for teaching purposes)
            LambdaExampleClass.SelectExampleAsForEach();

            // 20.2.2 Where Example
            // The array method Where can be used to filter elements of an array.
            // Where the select statement returns a value to be stored, the where Lambda statement
            // returns a boolean (true or false). All true return values are stored in the new array
            // while false return values are discarded.

            // e.g. nums.Where(x => (x % 2 == 0));
            // This method is essentially returning all of the even values and storing them in a new array

            LambdaExampleClass.WhereExample();

            // This method does the same thing as the Lambda where with a for-each (for teaching purposes)
            LambdaExampleClass.WhereExampleAsForEach();

            // 20.3 Creating a one-to-many relationship
            // In order to create a one-to-many relationship using EntityFrameworkCore in C#, we need to setup
            // both sides of the relationship

            // For our example, we'll be adding an event category to our CodingEvents project.

            // This requires updates in a few places

            // 1) The Event class requires two properties for an EventCategory (which is a new class)
            // EventCategory property - to actually store the event category object
            // int property - to store the event category ID (primary key)
            // This sets up the ONE side of our relationship

            // 2) The EventCategory class requires one new property for a LIST of events
            // List<Event> Events - the list of events related to this event category
            // This sets up the MANY side of our relationship (you can tell since we're using a list)

            // 3) The EventDbContext class requires a new property for the EventCategories to be used
            // This allows us to use the CRUD methods with our MySQL database

            // 4) We need to do a new migration (since we're storing new data in the database now) and update
            // A) dotnet ef migrations add RelateEventsAndCategories - This will create the entry in __EFMigrationsHistory table
            // B) dotnet ef database update - This will apply the update and create a new table Categories as well
            // as the relationship between the tables (by adding a CategoryId column to the Events table)

            // When fetching Event data from the database, we need to tell the EntityFrameworkCore
            // to fetch the relationship (for event category), we do that using the Include() and
            // a lambda like the one below
            // e.g. List<Event> events = dbContext.Events.Include(e => e.Category).ToList();

            // The rest of the reading refactors the views, viewmodels, and controllers
            // to use the new event categories, which you should all be experts in now ;)

            // ----- PART 2 -----

            // 20.4 - Some setup

            // The reading goes into little detail about setting up the code events project for
            // event tags (which we'll use for many-to-many relationships), regardless, there
            // is a bite of wisdom.

            // We we want to use the .Include (for eagerly loading data with relationships) and
            // then filter, we can use the .Single(lambda goes here to filter to a single entry)

            // e.g. dbContext.Events.Include(e => e.Category).Single(e => e.Id == id);

            // 20.5 Creating many-to-many relationships

            // In order to relate two classes in a many-to-many fashion, we need something called a join table.
            // This allows us to use two one-to-many relationships to create a many-to-many relationship.

            // A join table has two columns that represent the primary key for each of the tables the relationship forms.

            // e.g. a EventTag table with EventId and TagId from the Event and Tag tables respectively.

            // The C# counterpart to the join table also needs to be created, refer to the EventTag class.
            // In order for entityframeworkcore to work, we need to have two values for each side of the
            // relationship (event and tag)

            // EventId (primary key) and the Event object
            // TagId (primary key) and the Tag object

            // Composite keys... remember them?
            // A composite key is a primary key that is made up of two columns whose concatenated value is unique,
            // we do this in our DbContext OnModelCreating() method

            // modelBuilder.Entity<EventTag>().HasKey(e => new { e.EventId, e.TagId });

            // A lot of the reading has us going through setting up the views, view models, controllers, etc.
            // which I will not be going through in this lecture becuase we've done it a few times now ;)

            // Note: They did not mention running the dotnet ef commands... see above :)
        }
    }
}