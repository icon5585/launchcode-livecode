using System;

namespace HelloMethods
{
    public class Program
    {
        // Main method is the entry point of C# console applications
        // Note: In a C# project, only one Main method is allowed
        public static void Main(string[] args)
        {
            string message = Message.GetMessage("fr");  // Calling a static method using ClassName.MethodName(arguments)
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
