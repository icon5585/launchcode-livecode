using System;

/**
 * LC 101 - Unit 2 
 * Class 2.5
 * Chapter 5 - Classes & Objects, Part 2
 * Hank DeDona
 * 10/13/20
 */
namespace Class_2._5
{
    class Lecture
    {
        static void Main(string[] args)
        {
            // Pre-lecture
            FieldsVsProperties();

            // 5.1 Customizing Fields
            Chapter51();

            // 5.2 Instance and Static Methods
            Chapter52();

            // 5.3 Special Methods
            Chapter53();
        }

        public static void FieldsVsProperties()
        {
            // Fields store data
            // Properties provide access to data (with underlying fields) - this is an example of abstraction
            FieldsVsProperties fvp = new FieldsVsProperties();

            fvp.SetField1("field 1 value setter");
            Console.WriteLine("Field 1: " + fvp.GetField1());       // Note: Notice the parenthesis () - signifying a method call


            fvp.Property1 = "property 1 value";
            Console.WriteLine("Property 1: " + fvp.Property1);      // Note: Notice there aren't any parenthesis () - signifying a property

            fvp.Property2 = "";     // Blank value, should not set it
            Console.WriteLine("Property 2: " + fvp.Property2);

            fvp.Property2 = "proerty 2 value";
            Console.WriteLine("Property 2 again: " + fvp.Property2);
        }

        public static void Chapter51() {
            // 5.1.1 Readonly Fields
            // Refer back to when I was talking about immutable properties, this is where the READONLY keyword comes in

            FinalFields demo = new FinalFields();

            // This would result in a compiler error because IntValue has already been initialized.
            // CS0191: A readonly field cannot be assigned to (except in a constructor or init-only setter of the class in which the field is defined or a variable initializer))
            // demo.intValue = 6;

            // This isn't allowed since we didn't initialize DoubleValue in the class declaration.
            // demo.doubleValue = 42.0;

            // This would result in a compiler error, since we're trying to give objectValue a different actual object
            // demo.objectValue = new FortyTwo();

            // However, this is allowed since we're changing a field inside the final object, and not changing which object objectValue refers to.
            // Note: We're not changing the object, just a value inside the object. This is allowed
            demo.objectValue.intValue = 6;

            // 5.1.2 Static Fields
            // Static fields are fields (or properties) that belong to the class and are shared among ALL instances of a class
            // Note: Be careful about using static fields that are mutable as you will change the value for all instances.

            // If the static field is public, we can do this
            // Note: I didn't have to create a "new" Temperature object in order to access the AbsoluteZeroFahrenheit property
            Console.WriteLine("Absolute zero in F is: " + Temperature.AbsoluteZeroFahrenheit);
             
            // If we have an object named "temp" of type Temperature, we cannot do this. Remember that static properties are part of the class, not the instance
            Temperature temp = new Temperature();
            // Console.WriteLine("Absolute zero in F is: " + temp.absoluteZeroFahrenheit);

            // 5.1.3 Constants
            // In C#, we can also declare a constant, or unchanging, variable, using the const keyword.
            // Couple of things to note.
            // 1) Constants are usually public as they cannot be changed, there's no reason to make them private
            // 2) Constants are declared in ALL CAPS with UNDERSCORES (snake case)
            Console.WriteLine("PI is: " + Constants.PI);
        }

        public static void Chapter52() {
            // 5.2.2 Instance Methods
            // Instance methods define the behaviors that are unique or specialized to each class. Every object created from a class will carry a copy of these methods.
            // Note: These methods work on the fields of the instance of the object/class.
            // i.e. Instance methods depend on the data stored in an INDIVIDUAL OBJECT. If two objects call the same method, the results will vary when the objects contain different data.

            // e.g. Lets look at this Hello class, there are 2 instances of the hello class calling the same method, but with different output based on its data.

            Hello hello1 = new Hello("Hello class 1");

            Hello hello2 = new Hello("Goodbye class 2");

            Console.WriteLine(hello1.GetMessage());      // Hello class 1
            Console.WriteLine(hello2.GetMessage());      // Goodbye class 2

            // 5.2.3 Static Methods
            // Similar to static fields, static methods belong to the class as a whole, and not a specific instance. As such, they are shared by all instances of a class!

            Hello.HelloWorld();     // e.g. calling the static method HelloWorld() on the Hello class.

            // Will not work as static methods are not accessible from instance objects
            // hello1.HelloWorld();

            // One common error new C# coders encounter is when a static method tries to call an instance variable.
            // Static methods reference instance properties is not allowed, 
        }

        public static void Chapter53() {

            // 5.3.1 ToString
            // Returns a string representation of an object
            // Note: The default ToString implementation is generally not very useful, 99 times out of 100 you'll want
            // to write your own ToString method to be at all useful.

            // Note: In order to do this you'll need to use the OVERRIDE keyword
            // e.g. public override string ToString()

            Student person = new Student("Violet");
            Console.WriteLine(person.ToString());

            // 5.3.2 Equals
            // Allows you to compare two objects, NOT 2 memory locations
            // This is a hiccup new developers usually run into

            Student student1 = new Student("Maria", 1234);
            Student student2 = new Student("Maria", 1234);

            Console.WriteLine(student1 == student2);        // False! They do not share the same memory location.
            Console.WriteLine(student1.Equals(student2));   // True! They have the same values and are of the same class type

            Student bono1 = new Student("Paul David Hewson", 4);
            Student bono2 = new Student("Bono", 4);

            Console.WriteLine(bono1.Equals(bono2));         // False! They have different values even though they are both "Students"

            // The default Equals() method and the == operator test for identity, whereas we want to test for equality instead.
            // We can override the Equals() method to get the behavior we want.

            // Refer to the Student classes Equals() method

            // 5.3.2.3 Characteristics of Equals
            // 1) Reflexivity: For any non-null reference value x, x.Equals(x) should return true.
            // 2) Symmetry: For any non-null reference values x and y, x.Equals(y) should return true if and only if y.Equals(x) also returns true.
            // 3) Transitivity: For any non-null reference values x, y, and z, if x.Equals(y) returns true and y.Equals(z) returns true, then x.Equals(z) should return true.
            // 4) Consistency: As long as x and y do not change, x.Equals(y) should always return the same result.
            // 5) Non-null: For any non-null reference value x, x.Equals(null) should return false.
        }



    }
}
