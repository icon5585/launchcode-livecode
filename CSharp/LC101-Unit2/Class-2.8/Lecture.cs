using System;
using System.Collections.Generic;

/**
 * LC 101 - Unit 2 
 * Class 2.8
 * Chapter 8 - Interfaces and Polymorphism
 * Hank DeDona
 * 10/22/20
 */
namespace Class_2._8
{
    class Lecture
    {
        static void Main(string[] args)
        {
            Chapter81();

            Chapter82();

            Chapter83();

            Chapter84();
        }

        private static void Chapter81()
        {
            // 8.1.1. Polymorphism
            // As we saw on Tuesday, Polymorphism also includes casting. 

            HouseCat suki = new HouseCat("Suki", 12);

            // Note: This takes in a CAT, it could be ANY class that extends cat (HouseCat, Tiger, etc)
            CatSitter annie = new CatSitter(suki);  

        }

        private static void Chapter82()
        {
            // 8.2. Interfaces
            // An interface is similar to an abstract class, with some important differences.
            // Interfaces allow us to create code organized by behavior, rather than static data. 

            // Interfaces can contain
            // 1) Constants
            // 2) Method signatures
            // 3) Static methods
            // 4) Default methods

            // Refer to the IFeedable interface
            
            HouseCat suki = new HouseCat("Suki", 12);
            CatSitter annie = new CatSitter(suki);

            annie.FeedThePet();

            // Benefits of interfaces
            // You can only extend one class, but you may implement many interfaces.
            // You can extend a class and implement an interface at the same time.
            // When you declare properties and return types to be interface types, you decouple code using your classes from the actual class types you use.
        }

        private static void Chapter83()
        {
            // 8.3. Interfaces and Abstract Classes

            // Differences between interfaces and abstract classes
            // 1) Again, can implement multiple interfaces, but only extend one class (abstract or otherwise)
            // 2) Abstract classes may contain non-constant fields, while interfaces can only contain constant fields.
            // 3) Abstract classes should be used to collect and specify behavior by related classes, while an interface should be used
            // to specify related behaviors that may be common across unrelated classes.


        }

        private static void Chapter84()
        {
            // 8.4. Interfaces In The Wild

            // 8.4.1. IComparer<T>
            // A class implements this interface to compare two objects of a given class.

            // It is used by collections such as List to sort its contents with the Sort method.

            // Refer to CatComparer

            // Compare(T, T) returns an integer which determines which of the two objects comes before (in other words, “is less than”) the other.
            // If the returned value is less than zero, then the first parameter comes before the second.

            // 8.4.2. IEnumerable<T>
            // Enable iteration over a collection of objects using foreach.

            // If you want to be able to use your objects in foreach loops, they must implement IEnumerable<T>

            // e.g. a list is enumerable as you can use it in a for each loop
            IEnumerable<string> collection = new List<string>();

            // add items to the collection
            // Note: we had to cast it to a list
            (collection as List<string>).Add("LaunchCode");

            foreach (string item in collection)
            {
                Console.WriteLine(item);
            }

            // 8.4.3. IList<T>
            // Enable access to objects in a collection by index using square bracket notation

            IList<string> collection2 = new List<string>();

            // Add items to the collection
            collection2[0] = "LaunchCode2";

            Console.WriteLine(collection2[0]);

            // 8.4.4. IDictionary<TKey, TValue>
            // Represent a collection of key/value pairs.

            IDictionary<string, string> collection3 = new Dictionary<string, string>();

            collection3["hello"] = "world";

            Console.WriteLine(collection3["hello"]);    // Should write "world"
        }
    }
}
