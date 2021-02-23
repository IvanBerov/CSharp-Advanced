using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ");
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumtionPerKm = double.Parse(input[2]);

                Car currCar = new Car
                {
                    Model = model,
                    FuelAmount = fuelAmount,
                    FuelConsumptionPerKilometer = fuelConsumtionPerKm
                };
                cars.Add(currCar);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split(" ");
                string carModel = tokens[1];
                double amountOfKm = double.Parse(tokens[2]);

                Car car = cars.FirstOrDefault(c => c.Model == carModel);

                bool isDrive = car.Drive(amountOfKm);

                if (isDrive == false)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                command = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
