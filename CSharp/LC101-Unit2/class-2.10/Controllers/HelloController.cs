using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace class_2._10.Controllers
{
    // 10.1.2.1 In order to designate this class as a controller, it must extend
    // the abstract class "Controller"
    // 10.4.2.1 Class-Level Attributes
    // You can specify a "base route" for the entire class, all methods will now be at /helloworld/...
    [Route("/helloworld")]
    public class HelloController : Controller
    {

        // 10.1.2.1/2 Controllers/mappings
        // GET: /<controller>/helloworld
        // We use attributes to define what this method in this controller does
        // GET (can also do POST, PUT or DELETE)
        [HttpGet]
        public IActionResult HelloWorld()
        {
            // This allows us to return static text/html directly in the controller using the Content object
            // and will return "Hello World!" in h1 (header 1)
            return Content("<h1>" + "Hello World!" + "<h1>", "text/html");
        }

        // 10.2.3. Controllers and Parameters
        // GET: /<controller>/welcome
        [HttpGet("welcome/{name?}")]
        // POST: /<controller>/welcome
        [HttpPost("welcome")]
        // Adding a string parameter to the welcome method specifies a query param, ironically named name :P
        // [Route("/welcome/{name?}")]
        public IActionResult Welcome(string name = "LaunchCode" /* this specifies a default value, making name optional */)
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }

        // 10.3.2 Sending form data
        [HttpGet]
        [Route("helloworldform")]
        public IActionResult GetHelloWorldForm()
        {
            // This will return a simple html form
            // When submitted it will do a POST to the /helloworld/welcome method
            string html = "<form method='post' action='/helloworld/welcome'>" +
               "<input type='text' name='name' />" +
               "<input type='submit' value='Greet Me!' />" +
               "</form>";

            return Content(html, "text/html");
        }

    }
}
