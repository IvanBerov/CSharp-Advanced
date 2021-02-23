using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new List<Tire[]>();

            var input = Console.ReadLine();

            while (input != "No more tires")
            {
                var token = input.Split().ToList();

                var newTire1 = new Tire(int.Parse(token[0]), double.Parse(token[1]));
                var newTire2 = new Tire(int.Parse(token[2]), double.Parse(token[3]));
                var newTire3 = new Tire(int.Parse(token[4]), double.Parse(token[5]));
                var newTire4 = new Tire(int.Parse(token[6]), double.Parse(token[7]));

                tires.Add(new Tire[] { newTire1, newTire2, newTire3, newTire4 });

                input = Console.ReadLine();
            }

            var engines = new List<Engine>();

            input = Console.ReadLine();

            while (input != "Engines done")
            {
                var token = input.Split().ToList();

                var newEngine = new Engine(int.Parse(token[0]), double.Parse(token[1]));

                engines.Add(newEngine);

                input = Console.ReadLine();
            }

            var cars = new List<Car>();

            input = Console.ReadLine();

            while (input != "Show special")
            {
                var carDescription = input.Split().ToList();

                var make = carDescription[0];
                var model = carDescription[1];
                var year = int.Parse(carDescription[2]);
                var fuelQuantity = double.Parse(carDescription[3]);
                var fuelConsumption = double.Parse(carDescription[4]);
                var engine = engines[int.Parse(carDescription[5])];
                var tire = tires[int.Parse(carDescription[6])];
                var car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tire);

                cars.Add(car);
                input = Console.ReadLine();
            }

            cars = cars
                 .Where(x => x.Year >= 2017 &&
                 x.Engine.HorsePower > 330 &&
                 x.Tires.Sum(y => y.Pressure) >= 9 &&
                 x.Tires.Sum(y => y.Pressure) <= 10).ToList();

            foreach (var item in cars)
            {
                item.Drive(20);
                Console.WriteLine(item.WhoAmI());
            }

        }
    }
}
