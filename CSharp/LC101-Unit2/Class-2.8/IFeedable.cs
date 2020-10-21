using System;
namespace Class_2._8
{
    // interface keyword
    public interface IFeedable
    {
        // 8.2.1.1 Only includes a method signature
        // Note: All interface method signatures are public by default, no need to declare as such
        // Note 2: No need to use the "virtual" keyword here for interfaces, only classes need to do that
        void Eat();

        // 8.2.1.2 Static methods
        static void DoSomethingForAllFeedables()
        {
            Console.WriteLine("This static method the same for all implementations of IFeedable");
        }

        // 8.2.1.3. Default Methods
        void Nap()
        {
            // All implementations of IFeedable get this method by default, however, it can be overridden as well
            // The intended purpose of default methods is to allow programmers to add a method to an interface that has already been released.
            // If we add a new method signature instead, that would break all classes that impelment it since it wouldn't have that method already!
            Console.WriteLine("snooooozzze");
        }

    }
}
