using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

/**
 * LC 101 - Unit 2 
 * Class 2.13
 * Chapter 13 - ASP.net & Razor Templates
 * Hank DeDona
 * 11/10/20
 */
namespace class_2._13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


        private static void Lecture()
        {
            // 13.1 Templates
            // Templates allow us to "inject" dynamic content into our web views using placeholders
            // When we begin to talk about HTML pages, you'll see us start to use {variables} in curly brackets

            // This will allow us to add values dynamically based on the request coming from our users

            // Templates provide STRUCTURE, not CONTENT

            // 13.2 Creating a Template
            // For LC101, we'll be using Razor templates, which allows us to write C# in HTML template pages
            // Razor reference page: https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-3.1

            // 13.2.2.1 Controllers return view templates
            // Once we create a new .cshtml view template and populate it, we will have to update our controllers
            // to return the template instead of hard-coded HTML. We do this via the View() method.

            // The View() method returns the template based on the IActionResult method name OR you can put the
            // name of the view in quotes inside the View("Welcome") for example.

            // 13.3 Using a template
            // Now that we've created a "static" template, basically to return the same HTML code we had hard-coded
            // in our controller, lets pass some dynamic data into it!

            // 13.3.1 Passing data to a template
            // ViewBag objects are what Razor templates use to pass data between the controller and the view

            // Controller code to add "someProperty" key with the value "SomePropertyData"
            // ViewBag.someProperty = "SomePropertyData";

            // View code to read the "someProperty" data
            // <p>@ViewBag.someProperty</p>

            // 13.4 Interating in a template
            // You can easily iterate in a template for things like HTML lists using our friend, the FOREACH
            // but make sure the property is set to a collection (like a list) in the controller

            // 13.4.1 Nested loops
            // Just as you can iterate a single loop, you can also iterate over nested loops
            // Note: This is commonly used when iterating over a list of objects that they themselves
            // have a list of properties

            // 13.5 Conditionals in a template
            // 13.5.1 Display content if/else
            // View code for "if"
            // @if (condition)

            // 13.6 Razor Forms
            // For the remainder of this lecture we will be using the CodingEvents project in this LC101-Unit2 solution

            // Refer to the EventsController.cs Index method and Index.cshtml under the Events directory in the Views directory

            // 13.6.4 Create and render a form
            // Refer to the EventsController.cs Add() method and Add.cshtml under the Events directory in the Views directory

            // 13.6.6 Handle form submission
            // Refer to the EventsController.cs AddNewEvent() method

            // Notice that we don't have to return HTML or a view template for our response in our controller, we can also
            // redirect the user to somewhere else. In this case it's back to the /events path which is handled by our index method

            // We also want to add a link to the "add event" page from our events page, we can use an anchor tag in our template
            // <a asp-controller="Events" asp-action="Add">Add Event</a>
            // The asp-controller tells C# what controller to make the link to, the asp-action provides the additional path param
            // So the value of the line above is /Events/Add

            // From the ASP.net doc:
            // The asp-controller attribute assigns the controller used for generating the URL.
            // The asp-action attribute value represents the controller action name included in the generated href

            // 13.7 The shared directory
            // We've already touched on this a bit when we mentioned the shared _Layout.cshtml template

            // Layout pages are used for the headers and footers of pages, for example having a link to your privacy policy
            // As we can reuse code in our programs, we can also create "partial views" that can be reused across different views.

            // 13.7.2 Partial views
            // Refer to the _LinkListPartial.cshtml in the Shared directory and the Index.cshtml in the Events directory Views directory

            // 13.8 Static resources
            // When we say "static resources" we usually refer to things that don't change like CSS, JS, images, etc.

            // Site.css is included in our _Layout.cshtml layout template, so make sure that either
            // A) Don't use the provided Layout template
            // B) Make sure the CSS you write overrides any provided CSS in the Site.css provided

            // CSS is stored, like other static content, in the wwwroot directory under the css directory
            // To use static content in your views, simply provide the href to...
            // ~/css/custom.css for CSS files
            // ~/js/custom.js for JS files
            // ~/images/custom.png for image files

            // 13.9 Bootstrap
            // Bootstrap is a commonly used theme library which consists of some javascript, but mostly cascading style sheets
            // This provides a standardized color scheme and helper library functions, it's used by many companies

            // Bootstrap is already provided to you in your _Layout.cshtml layout template, you simply need to add the
            // classes to your HTML elements

            // 13.9.2 Bootstrap layout
            // Basically a container/row system that is separated using DIVs
            // https://getbootstrap.com/docs/4.4/layout/grid/

            // 13.9.3 Bootstrap tables
            // https://getbootstrap.com/docs/4.4/content/tables/

            // 13.9.4 Bootstrap forms
            // https://getbootstrap.com/docs/4.4/components/forms/
        }
    }
}
