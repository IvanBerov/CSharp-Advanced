using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] inputCar = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = inputCar[0];
                int engineSpeed = int.Parse(inputCar[1]);
                int enginePower = int.Parse(inputCar[2]);
                int cargoWeight = int.Parse(inputCar[3]);
                string cargoType = inputCar[4];

                string[] tiresData = new string[8];

                for (int x = 0; x < tiresData.Length; x++)
                {
                    tiresData[x] = inputCar[5 + x];  // adding tire 
                }

                Car newCar = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tiresData);

                cars.Add(newCar);
            }
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars.Where(x => x.Cargo.Type == "fragile"))
                {
                    bool lowPressure = car.Tires.Any(x => x.Pressure < 1);

                    if (lowPressure)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else//flamable
            {
                foreach (var car in cars.Where(x => x.Cargo.Type == "flamable"))
                {
                    if (car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
