using System;
namespace Class_2._3
{
    public class HelloWorld
    {
        public string message = "Hello World";

        // 4.4 Constructor example that takes in a message, default no-arg constructor is provided by default
        // NOTE: If you provide a constructor, the default one is no longer available and must be defined verbosely
        public HelloWorld(string message)
        {
            this.message = message;
        }

        // Default no-arg constructor that does nothing!
        public HelloWorld() { }

        public void SayHello()
        {
            // 4.1.2 The this keyword
            // Whenever you use this, it always refers to the object that the given code is currently within.
            string message = "Goodbye World";

            // The line below prints "Goodbye World" which is defined above
            Console.WriteLine(message);

            // The line below prints "Hello World" which is defined at the top of the class
            Console.WriteLine(this.message);
        }

    }
}
