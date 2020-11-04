using System;
namespace Class_2._12
{
    public class Temperature
    {

        private double fahrenheit;
        public static double AbsoluteZeroFahrenheit { get; } = -459.67;

        public Temperature(double fahrenheit)
        {
            Fahrenheit = fahrenheit;
        }

        /*
        public Temperature(double fahrenheit)
        {
            // 11.2.1 Try/Catch/Finally
            try
            {
                Fahrenheit = fahrenheit;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Fahrenheit = -459.67;
            }
        }
        */

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
