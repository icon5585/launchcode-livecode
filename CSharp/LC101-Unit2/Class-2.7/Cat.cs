using System;
namespace Class_2._7
{

    public class Cat
    {
        public bool Tired { get; set; } = false;
        public bool Hungry { get; set; } = false;
        public double Weight { get; set; }
        public string Family { get; } = "Felidae";

        public Cat(double weight)
        {
            Weight = weight;
        }

        public Cat() { }

        public void Sleep()
        {
            Tired = false;
            Hungry = true;
        }

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

