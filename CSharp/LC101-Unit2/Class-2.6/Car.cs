using System;

namespace Class_2._6
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int GasTankSize { get; set; }
        public double GasTankLevel { get; set; }
        public double MilesPerGallon { get; set; }
        public double Odometer { get; set; } = 0;

        public Car(string make, string model, int gasTankSize, double milesPerGallon)
        {
            Make = make;
            Model = model;
            GasTankSize = gasTankSize;
            // Gas tank level defaults to a full tank
            GasTankLevel = gasTankSize;
            MilesPerGallon = milesPerGallon;
        }

        /**
         * Drive the car an amount of miles. If not enough fuel, drive as far as fuel allows.
         * Adjust fuel levels based on amount needed to drive the distance requested.
         * Add miles to odometer.
         */
        public void Drive(double miles)
        {
            //adjust fuel based on mpg and miles requested to drive
            double maxDistance = MilesPerGallon * GasTankLevel;
            /** The double below uses some syntax called the ternary operator.
             * if the value of miles is greater than the value of maxDistance,
             * then milesAbleToTravel = maxDistance.
             * otherwise, if miles is not greater than maxDistance,
             * then milesAbleToTravel = miles
             */
            double milesAbleToTravel = miles > maxDistance ? maxDistance : miles;
            double gallonsUsed = milesAbleToTravel / MilesPerGallon;
            GasTankLevel -= gallonsUsed;
            Odometer += milesAbleToTravel;
        }

    }
}
