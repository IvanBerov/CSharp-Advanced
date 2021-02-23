using System;
using System.Collections.Generic;

namespace CarSalesman
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < n; i++)
            {
                string[] engineInputInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = engineInputInfo[0];
                int power = int.Parse(engineInputInfo[1]);

                int displacement = 0;     // default value
                string efficiency = null;

                Engine newEngine;

                // Different input validation

                if (engineInputInfo.Length == 4)
                {
                    displacement = int.Parse(engineInputInfo[2]);
                    efficiency = engineInputInfo[3];
                    newEngine = new Engine(model, power, displacement, efficiency);
                    engines.Add(newEngine);
                }
                else if (engineInputInfo.Length == 3)
                {
                    bool isNumeric = int.TryParse(engineInputInfo[2], out displacement);

                    if (isNumeric) // if input is int displacement
                    {
                        newEngine = new Engine(model, power, displacement);
                    }
                    else          // if input is string efficiency
                    {
                        efficiency = engineInputInfo[2];
                        newEngine = new Engine(model, power,efficiency);
                    }

                    engines.Add(newEngine);
                }
                else if (engineInputInfo.Length == 2) // if input is only model and power
                {
                    newEngine = new Engine(model, power);
                    engines.Add(newEngine);
                }
            }

            int m = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                string[] autoInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = autoInfo[0];
                string engineInput = autoInfo[1];

                Engine engine = engines.Find(x => x.Model == engineInput);

                int weight = 0;
                string color = null;

                Car newCar;

                if (autoInfo.Length == 4)
                {
                    weight = int.Parse(autoInfo[2]);
                    color = autoInfo[3];
                    newCar = new Car(model, engine, weight, color);
                    cars.Add(newCar);
                }
                else if (autoInfo.Length == 3)
                {
                    // if its int we take out weight
                    bool isNum = int.TryParse(autoInfo[2], out weight);
                    if (isNum)
                    {
                        newCar = new Car(model, engine, weight);
                    }
                    else
                    {
                        color = autoInfo[2];
                        newCar = new Car(model, engine, color);
                    }
                    cars.Add(newCar);
                }
                else if (autoInfo.Length == 2)
                {
                    newCar = new Car(model, engine);
                    cars.Add(newCar);
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
