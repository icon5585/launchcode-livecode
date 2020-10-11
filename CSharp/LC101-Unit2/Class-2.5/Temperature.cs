using System;
namespace Class_2._5
{
    public class Temperature
    {
        private double fahrenheit;
        public static double AbsoluteZeroFahrenheit { get; } = -459.67;

        public double Fahrenheit
        {
            get
            {
                return fahrenheit;
            }
            set
            {

                if (value < AbsoluteZeroFahrenheit)
                {
                    throw new ArgumentOutOfRangeException("Value is below absolute zero");
                }

                fahrenheit = value;
            }
        }
    }
}
