using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> cars = new HashSet<string>();
            while (input != "END")
            {
                string[] tokens = input.Split(", ");
                string command = tokens[0];
                string carNum = tokens[1];
                if (command == "IN")
                {
                    cars.Add(carNum);
                }
                else if (command == "OUT")
                {
                    cars.Remove(carNum);
                }
                input = Console.ReadLine();
            }
            if (cars.Any())
            {
                foreach (var item in cars)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
