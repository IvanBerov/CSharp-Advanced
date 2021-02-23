using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {

        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
             
    }
        public Car(string make,string model,int year)
            :this()
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public Car(string make, string model, int year,double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity ,fuelConsumption)
        {
            Engine = engine;
            Tires = tires;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelConsumption { get; set; }
        public double FuelQuantity { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        public void Drive(double distance)
        {
            double expenceFuel = FuelConsumption * distance / 100;

            if (expenceFuel > FuelQuantity)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                FuelQuantity -= distance / 100 * FuelConsumption;
            }
        }
        public string WhoAmI()
        {

            StringBuilder str = new StringBuilder();
            str.AppendLine($"Make: {this.Make}");
            str.AppendLine($"Model: {this.Model}");
            str.AppendLine($"Year: {this.Year}");
            str.AppendLine($"HorsePowers: {this.Engine.HorsePower}");
            str.Append($"FuelQuantity: {this.FuelQuantity}");

            return str.ToString();
        }
    }
}
