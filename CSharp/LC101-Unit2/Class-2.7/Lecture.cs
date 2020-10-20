using System;
using System.Collections.Generic;

/**
 * LC 101 - Unit 2 
 * Class 2.7
 * Chapter 7 - Inheritance
 * Hank DeDona
 * 10/20/20
 */
namespace Class_2._7
{
    class Lecture
    {
        // Remember: This is the main entry point for this C# application and can only have 1 per project :)
        static void Main(string[] args)
        {
            DictionariesExplained();

            Chapter73();

            Chapter74();

            Chapter75();
        }


        private static void DictionariesExplained() {
            // Dictionaries are key value pairs
            // You typically use a dictionary by "getting" the value by the key
            // The Dictionary is part of the SYstem.Collections.Generic package

            // Declaring a new dictionary that has keys that are strings as well as values that are strings
            Dictionary<string, string> hankDictionary = new Dictionary<string, string>();

            hankDictionary.Add("workplace", "Cerner");
            hankDictionary.Add("homestate", "New York");
            hankDictionary.Add("hometown", "Yorktown Heights");
            hankDictionary.Add("almamater", "RIT");

            // So... What have we created...

            /**
             * Dictionary
             * Name: hankDictionary
             * 
             * Elements:
             * key ----> value
             * ---------------
             * workplace ----> Cerner
             * homestate ----> New York
             * hometown -----> Yorktown Heights 
             * almamater ----> RIT
             */

            // If we add an element with the same key, but different value, it will throw an ArgumentException
            // hankDictionary.Add("almamater", "Alfred State");

            // How do we access values of a dictionary, a couple of different ways.
            // 1) Access it like an array using square brackets dictionary[key]
            // 2) Use the TryGetValue(key, value)
            // 3) Iterate over it like an array using the foreach

            // 1)
            Console.WriteLine(hankDictionary["almamater"]);

            // 2)
            string tempAlmamater;

            // Note: TryGetValue returns true if the element with a provided key exists, false otherwise
            if (hankDictionary.TryGetValue("almamater", out tempAlmamater))
            {
                Console.WriteLine(tempAlmamater);
            }

            // 3)
            // Note: This way of getting values is usually used when you want to iterate over all key/value pairs in a dictionary
            foreach (KeyValuePair<string, string> tempKeyValuePair in hankDictionary)
            {
                Console.WriteLine(tempKeyValuePair);   
            }
        }

        private static void Chapter73()
        {
            // 7.3.1 Inheriting Fields and Properties
            HouseCat garfield = new HouseCat("Garfield", 12.0);
            garfield.Eat();
            Console.WriteLine(garfield.Tired);   // prints true

            // 7.3.2 Base
            HouseCat spike = new HouseCat("Spike");
            Console.WriteLine(spike.Weight);   // prints 0
            spike.Weight = 13;
            Console.WriteLine(spike.Weight);   // prints 13

            // 7.3.3 override
            // We've been introduced to the override keyword already in a previous lecture when
            // we were overriding the ToString, Equals and GetHashCode methods that are all
            // present in the base Object class.

            // When we want to modify the behavior of a method in the base class, we can override it in sub-classes
            // In order to accomplish this in our Cat/HouseCat example we will require another new keyword, virtual

            Cat plainCat = new Cat(8.6);
            HouseCat cheshireCat = new HouseCat("Cheshire Cat", 26.0);

            Console.WriteLine(plainCat.Noise()); // prints "Meow!"
            Console.WriteLine(cheshireCat.Noise()); // prints "Hello, my name is Cheshire Cat!"
        }

        private static void Chapter74()
        {
            // 7.4. Inheriting from Abstraction
            // 7.4.1 abstract Classes

            // Abstract classes are base classes designed to be extended (sub-classed) but NOT
            // to be instantiated. You cannot instantiate an instance of an abstract class using the new keyword.

            // 7.4.2 abstract Methods
            // Abstract methods are methods without a method body, i.e. they have no code associated with the method,
            // just a method signature.

            // Note: Any base classes with abstract methods that are extended, the extended class MUST implement a method
            // with a method body that matches the method signature.
        }

        private static void Chapter75()
        {
            // 7.5 Casting
            // We've seen casting before when writing our Equals methods in a previous lecture. 
            // Casting allows us to exploit one of the pillars of OOP, more specifically polymorphism.

            // Note: We are declaring suki as a Cat and instantiating as a HouseCat
            Cat suki = new HouseCat("Suki", 8);

            suki.Noise(); // Meow!

            // Results in a compiler error, since Cat doesn't have such a method
            // suki.IsSatisfied();

            // How do we avoid this? Declare suki as a HouseCat... OR... cast suki to a HouseCat
            // As long as suki really is a HouseCat, this works
            (suki as HouseCat).IsSatisfied();

            // Side note: We can check beforehand to make sure that suki really is of class HouseCat
            // before casting, this will prevent a runtime exception being thrown
            if(suki is HouseCat)
            {
                // Since this is true, we can safely cast suki to a HouseCat
                (suki as HouseCat).IsSatisfied();
            }

        }

    }
}
