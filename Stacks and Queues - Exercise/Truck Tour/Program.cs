using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPomp = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < numOfPomp; i++)
            {
                string input = Console.ReadLine();
                input += $" {i}";
                queue.Enqueue(input);
            }

            int totalFuel = 0;

            for (int i = 0; i < numOfPomp; i++)
            {
                string currInfo = queue.Dequeue();

                var info = currInfo
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                var fuel = info[0];
                var distance = info[1];
                totalFuel += fuel;

                if (totalFuel >= distance)
                {
                    totalFuel -= distance;
                }
                else
                {
                    totalFuel = 0;
                    i = -1;
                }
                queue.Enqueue(currInfo);
            }

            var firstElement = queue.Dequeue().Split().ToArray();

            Console.WriteLine(firstElement[2]);
        }
    }
}
