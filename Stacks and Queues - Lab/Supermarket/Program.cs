using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Queue<string> names = new Queue<string>();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    foreach (var item in names)
                    {
                        Console.WriteLine(item);
                    }
                    //while (names.Count > 1)
                    //{
                    //    Console.WriteLine(names.Dequeue());
                    //}
                    //Console.WriteLine(names.Peek());
                    names.Clear();
                }
                else
                {
                    names.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
