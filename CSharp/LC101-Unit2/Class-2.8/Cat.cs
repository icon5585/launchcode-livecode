using System;
namespace Class_2._8
{
    // 8.2.2. Implementing an interface
    // Same syntax as extending a class, using the ":"
    public class Cat : IFeedable
    {
        public bool Tired { get; set; } = false;
        public bool Hungry { get; set; } = false;
        public double Weight { get; set; }
        public string Family { get; } = "Felidae";

        public Cat(double weight)
        {
            Weight = weight;
        }

        public Cat(double weight, Boolean tired)
        {
            Weight = weight;
            Tired = tired;
        }

        public Cat() { }

        public void Sleep()
        {
            Tired = false;
            Hungry = true;
        }

        // Also note, we didn't need to override it
        public void Eat()
        {
            if (!Hungry)
            {
                Tired = true;
            }

            Hungry = false;
        }

        // 7.3.3 By adding the virtual keyword here, it tells C# that this method can be overridden in sub-classes
        public virtual string Noise()
        {
            return "Meow!";
        }

    }
}

