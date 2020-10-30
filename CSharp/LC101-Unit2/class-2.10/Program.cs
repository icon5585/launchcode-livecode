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
 * Class 2.10
 * Chapter 9 & 10 - ASP.net/MVC/Controllers & Routing
 * Hank DeDona
 * 10/29/20
 */
namespace class_2._10
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
            // 10.1 Simple Controllers
            // Controllers, the traffic cops of web applications/services

            // 10.1.1 Controllers and static responses
            // Controllers are found in the "Controllers" directory of your ASP.net core project
            // Note: Surprise, views are in the "Views" directory and models in the "Models" directory

            // Let's create our first controller, refer to HelloController.cs in this project
            // The routing pattern of controllers is controller/action, e.g. Home/Index (this is in the HomeController.cs

            // In order to specify the HTTP method supported by your controller method, we use attributes
            // GET [HttpGet]
            // POST [HttpPost]
            // PUT [HttpPut]
            // DELETE [HttpDelete]

            // In order to specify the route, we need another attribute
            // [Route("/helloworld")]

            // For our home controller we will specify the HTTP method (in this case GET) as well as the
            // path (in this case HelloWorld)
            // So the full URL would be https://localhost:{port}/helloworld

            // 10.2 Controllers with parameters
            // 10.2.1 Query strings - These are additional request parameters that are appended to your request URL
            // separated by the question mark "?" and delimited by the ampersand "&"

            // In order to add a query param to your controller method, you simply add a string variable to the parameters
            // The new URL for the welcome (passing in name) would be https://localhost:{port}/helloworld/welcome?name=milo
            // See Welcome() method in the HelloController.cs

            // 10.2.3.2 Path variables
            // We can use the [Route] attribute to specify path variables (parameters)
            // By putting the string "name" in curly brackets, it tells us that it's a variable, the "?" specifies that it's optional
            // e.g. [Route("/helloworld/welcome/{name?}")]

            // The new URL for the path-based welcome URL would be https://localhost:{port}/helloworld/welcome/milo

            // 10.3 Controllers with Forms
            // Refer to GetHelloWorldForm() in HelloController.cs

            // 10.4.2 Cleaning up the controller
            // You can specify routes at the class-level
            // e.g. [Route("/helloworld")]
            // This will say that ALL methods in this class will be at /helloworld/...

            // 10.4.2.2. One Method, Two Request Types
            // You can specify one method to handle multiple HTTP methods (e.g. GET and POST)
            // The HttpGet and other method attributes can also take in the path (route)
            // For example: 
            // [HttpGet("welcome/{name?}")]
            // [HttpPost("welcome")]

            // This removes the need for the [Route] attribute
        }
    }
}
