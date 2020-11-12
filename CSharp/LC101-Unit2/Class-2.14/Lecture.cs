using System;

/**
 * LC 101 - Unit 2 
 * Class 2.14
 * Chapter 14 - Models and Model Binding
 * Hank DeDona
 * 11/12/20
 */
namespace Class_2._14
{
    class Lecture
    {
        static void Main(string[] args)
        {
            // 14.1 Models in MVC
            // We've already talked about Controllers (the traffic cops) and Views (the UI)
            // and what the user sees, today we'll talk about the last piece of MVC, the model.

            // A model represents the logic for accessing and storing the data used in an application.

            // These are the classes (objects) we use to pass data to/from the controller to the view.

            // The view is really the only piece of the MVC puzzle that the user actually "sees"

            // Models include mechanics for storing, retreiving and organizing data.

            // 14.2 Create a Model
            // For the rest of this lecture, we will continue working on our CodingEvents project

            // For models, most of them will be POCOs (plain old C# objects), similar to POJOs (plain old java objects)

            // 14.3 Models and Data
            // It's a good idea to get in the habit of adding unique IDs to your model objects, especially if they will
            // be persisted in a datastore such as a database (as they will require a unique primary key)

            // Note that ID is a READ ONLY field! We should not be able to modify unique identifiers (especially ones
            // that are automatically assigned)

            // 14.3.6 Delete an event
            // Adding a unique ID will help IMMENSELY when deleting an event as we can delete by the unique ID. This will
            // prevent conflicts when deleting as we may have events with the same name perhaps.

            // 14.4 Model-binding
            // Instead of having to pass in form values one-by-one via the form params, we can use something called model
            // binding to allow ASP.net to handle the binding of the form values to the model for us.

            // In order to do this, the form names must match the properties of the POCO model object!

            // If the form name doesn't match the property value, you can use the [FromForm()] attribute
            // e.g. [FromForm(Name="desc")]

        }
    }
}
