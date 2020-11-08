using System;
using System.Collections.Generic;
using class_2._13.Models;
using Microsoft.AspNetCore.Mvc;

namespace class_2._13.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // 13.3.1 Passing data to a template using the key "testProperty"
            ViewBag.testProperty = "LaunchCode";

            // 13.4 Iterating in a template
            List<String> fruits = new List<string>
            {
                "Apple",
                "Banana",
                "Orange",
                "Pineapple"
            };

            ViewBag.fruits = fruits;

            // 13.4.1 Nested Loops
            CoffeeShop cs1 = new CoffeeShop
            {
                Name = "Central Perk",
                CoffeeOptions = new List<string>
            {
                "Espresso",
                "Instant"
            }
            };

            CoffeeShop cs2 = new CoffeeShop
            {
                Name = "Brews Brothers",
                CoffeeOptions = new List<string>
            {
                "French Roast",
                "Kopi Luwak"
            }
            };

            ViewBag.coffeeShops = new List<CoffeeShop> { cs1, cs2 };

            // 13.5.1 Display content if/else
            ViewBag.awesome = true;

            return View();  // Note: This will look for a .cshtml file called Index in the Hello folder
        }

        [HttpPost]
        [Route("/hello")]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
    }
}
