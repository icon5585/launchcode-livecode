using System;

/**
 * LC 101 - Unit 2 
 * Class 2.3
 * Chapter 4 - Classes & Objects, Part 1
 * Hank DeDona
 * 10/06/20
 */
namespace Class_2._3
{
    class Lecture
    {
        static void Main(string[] args)
        {
            // 4.1.1 A Minimal Class and Object
            // Example of a helloworld runner
            HelloWorld hello = new HelloWorld("Hello");
            hello.SayHello();

            // Refer to HelloWorld class

            // 4.2.1 Access Modifiers
            // public - everyone and everything
            // protected - can be access in the same class or any sub-classes
            // internal - this is the DEFAULT for classes, the type or member can be accessed by any code in the same assembly, but not from another assembly.
                // NOTE: When we say assembly we mean project/solution/library.
            // protected internal - The type or member can be accessed by any code in the assembly in which it's declared, or sub-classes
            // private - this is the DEFAULT for class members (properties), only visible inside class

            // 4.3.1. Encapsulation
            // Bundling of related data (properties) and behaviors (methods) in a single class
            // One of the 3 pillars of Object Oriented Programming

            // Refer to student class
            Student billy = new Student();
            billy.Name = "billy";
            billy.StudentId = 4096;
            Console.WriteLine("Students name is: " + billy.Name);
            Console.WriteLine("Students ID is: " + billy.StudentId);

            // 4.4 Constructors
            // We've already talked about constructors before, anytime we instantiate an object and use the
            // = new() we are calling the constructor of a class to create an instance.

            // HelloWorld has a constructor that takes in a message

            // 4.4.1 Overloading Constructors
            // We can have more than one constructor for a given class as long as they have different
            // method signatures.

            // Student has muiltiple overloaded constructors

            // 4.5 Methods
            // A method is a function that belongs to a class. In C#, all procedures must be part of a class.

            // 4.5.1 Calling Methods on Objects
            // Referring back to our Helloworld example
            HelloWorld hw = new HelloWorld();       // Instaiate an instance of the HelloWorld class
            hw.SayHello();                          // Calling the method SayHello on the object hw which is an instance of the HelloWorld class

            // 4.6 Single Responsibility Principle
            /*
		     * The single responsibility principle states that every module or class should
		     * have responsibility over a single part of the functionality provided by the
		     * software, and that responsibility should be entirely encapsulated by the
		     * class.
		     */

            // Basically what they're trying to say is that every class should do one thing
            // and one thing only!

            // If you're mixing and matching code, you should probably break them up into
            // two classes.

            // https://en.wikipedia.org/wiki/Single_responsibility_principle
        }
    }
}
