using System;
namespace Class_2._12
{
    public class Temperature
    {

        private double fahrenheit;
        public static double AbsoluteZeroFahrenheit { get; } = -459.67;
                
        public Temperature(double fahrenheit)
        {
            // 11.2.1 Try/Catch/Finally
            try
            {
                Fahrenheit = fahrenheit;

                // What if I had to do more here?
                // If exception is thrown, this code won't be called
            }
            catch (ArgumentOutOfRangeException e)
            {
                Fahrenheit = AbsoluteZeroFahrenheit;
                Console.WriteLine(e.ToString());
            }
            finally
            {
                // This code is GUARANTEED to run regardless if an exception is thrown
            }
        }
        
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
