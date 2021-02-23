using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public bool Drive(double distanceTraveld)
        {
            double neededFuel = distanceTraveld * this.FuelConsumptionPerKilometer;

            if (neededFuel > this.FuelAmount)
            {
                return false;
            }

            this.FuelAmount -= neededFuel;
            this.TravelledDistance += distanceTraveld;

            return true;
        }
    }
}
