using System;
namespace Class_2._7
{
    // HouseCat extends the Cat class
    public class HouseCat : Cat
    {
        public string Name { get; set; }
        public string Species { get; } = "Felis catus";

        // 7.3.2 The base keyword refers to the parent class, in this case the Cat class
        // since the parent class has a constructor that takes in weight
        public HouseCat(string name, double weight) : base(weight)
        {
            Name = name;
        }

        // This uses the no-arg constructor in the Cat class technically
        public HouseCat(String name)
        {
            Name = name;
        }

        public HouseCat(String name, double weight, bool tired) : base(weight, tired)
        {
            Name = name;
        }

        // If we want a HouseCat constructor that takes in weight only, we have to define it
        // and call the base constructor like so, there is no constructor body
        // Note: We are not setting Name here, which is bad and only for teaching purposes
        public HouseCat(double weight) : base(weight)
        {}

        public bool IsSatisfied()
        {
            return !Hungry && !Tired;
        }

        // 7.3.3 Overrides the Noise() method present in the Cat class
        // Note: The method signature MUST be identical to the method being overridden
        public override string Noise()
        {
            if (IsSatisfied())
            {
                return "Hello, my name is " + Name + "!";
            }
            else
            {
                return base.Noise(); // Calls the Noise() method in the Cat class
            }
        }

        public string Purr()
        {
            return "I'm a housecat";
        }
    }
}
