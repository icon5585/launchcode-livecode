using System;   // 2.2.2. - Using
                // This allows us to access classes, methods, and data stored in different files (libraries, etc)

namespace TempConv
{
    class Program
    {
        public static void Main(string[] args)
        {
            double fahrenheit;
            double celsius;
            string input;

            // Note: Console is part of the System package, since we said "using System" above we don't have to do
            //System.Console.WriteLine("This is unnecessary because of our using above");


            // 2.2.4. Input / Output and the Console Class
            Console.WriteLine("Temperature in F:");     // Output
            input = Console.ReadLine();                 // Input a String
            fahrenheit = double.Parse(input);           // Convert to a double

            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The Temperature in C is: " + celsius);
            Console.ReadLine();
        }
    }
}
