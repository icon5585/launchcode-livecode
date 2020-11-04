using System;

/**
 * LC 101 - Unit 2 
 * Class 2.12
 * Chapter 11/12 - Exceptions and VS Tools
 * Hank DeDona
 * 11/05/20
 */
namespace Class_2._12
{
    class Lecture
    {
        static void Main(string[] args)
        {
            chapter11();

            chapter12();
        }

        private static void chapter11()
        {
            // 11.1 Exceptions
            // Exceptions in C# are objects derived from the System.Exception class

            // If you want to have an exceptional case in your code, we THROW them
            // throw new Exception("Oh noes!");

            // 11.1.1 When Exceptions Arise
            // Refer to Temperature.Fahrenheit (setter)
            // If the temperature is out of range, we throw an ArgumentOutOfRangeException

            // Works fine
            Temperature insideTemp = new Temperature(73);
            Console.WriteLine(insideTemp.Fahrenheit);

            // Throws an ArgumentOutOfRangeException
            Temperature outsideTemp = new Temperature(-8200);
            Console.WriteLine(outsideTemp.Fahrenheit);

            // 11.1.2 When to Use Exceptions
            // Exceptions are there to handle "exceptional" conditions, conditions at runtime
            // that you do not expect to happen normally (or in the happy case).

            // As you'll see we can handle exceptions when they pop up using try/catches.

            // 11.2 Handling Exceptions
            // You, as the developer, must determine whether or not to handle exceptions. ALL
            // exceptions in C# are unchecked (runtime) exceptions and do not require a try/catch

            // Refer to the Temperature class constructor (that's commented out)

            // The finally part of the try/catch block is the part of the try/catch/finally block
            // that is ALWAYS GUARANTEED to run regardless if an exception is thrown or not.
            // You can do some cleanup/set variables/etc in this block

            // Now sets it to absolute zero (-459.67)
            Temperature outsideTemp2 = new Temperature(-8200);
            Console.WriteLine(outsideTemp.Fahrenheit);

            // 11.2.1.1 What to Catch
            // Since all exceptions extend System.Exception you can have try/catch blocks that
            // catch Exception, which will catch ALL possible exceptions
            // This can cause exceptions to be "swallowed" if the catch block does not have any logging/handling

            // 11.2.2 How to Avoid Exceptions
            // Simply put, some exceptions can be unavoided, however, there are things you can do to prevent some :)

            // Two things you can do to reduce exceptions being thrown is to
            // 1) Validate user input - anytime you have users inputting data, there's a possibility that an invalid entry
            // will be provided. Proactively validate user input for null/blank/out of bounds data to prevent this.
            // 2) Check for null references - this will prevent ArgumentNullExceptions, anytime you try to call a
            // function on a null reference, a ArgumentNullException will occur

            // 11.3 Common Exception Objects
            // There are a few, commonly used exception objects you should familiarize yourself with as they are prevalent in C#

            // ArgumentOutOfRangeException - Thrown by methods that verify that arguments are in a given range
            // ArgumentNullException - Thrown by methods that do not allow an argument to be null
            // IndexOutOfRangeException - Thrown when trying to use an array index that is out of bounds for the array
            // InvalidOperationException - Thrown by methods when in an invalid state. e.g. Calling an Enumerable method on an empty collection: Enumerator.MoveNext()
        }

        private static void chapter12()
        {
            // 12.1 MSBuild
            // Allows for compiling source, managing dependencies, testing and packaging

            // 12.1.1. The Project File
            // This is the .csproj files that are numerous in this "solution"
            // Example: https://github.com/icon5585/launchcode-livecode/blob/master/CSharp/LC101-Unit2/Class-2.1/Class-2.1.csproj

            // What's in here?
            // OutputType - Exe - basically saying that this will be an executable (another example would be a web app)
            // TargetFramework - The version of .net core to use
            // RootNamespace - The main (or root) namespace of the project

            // 4 principal elements of the project file
            // 1) Tasks
            // 2) Targets
            // 3) Properties 
            // 4) Items

            // 12.2 NuGet
            // NuGet is a package management tool for .NET software. To use a dependency in a C# project,
            // we can rely on NuGet to connect us with third-party code. This is similar to maven in other languages

            // It allows us to simply add new dependencies to our projects without having to manually download and add them
            // Right clicking on the Dependencies and click "Manage NuGet Packages..."
            // This will allow us to pull in 3rd party dependencies for our projects :)

            // 12.3 Debugger
            // I've been using the debugger for our lectures, this allows you to "step through" your program
            // In the top left corner of Visual Studio you can see a drop down for release/debug, choose debug to
            // enable "breakpoints" in your code, these are points that your debugger will stop at

            // You can add a breakpoint by clicking on the left side of the coding window (next to the line number),
            // a red circle should appear showing that a breakpoint is added.
        }
    }
}
