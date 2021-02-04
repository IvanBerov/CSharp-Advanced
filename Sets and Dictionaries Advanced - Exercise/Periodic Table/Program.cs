using System;
using System.Collections.Generic;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ");
                foreach (var item in input)
                {
                    elements.Add(item);
                }
            }
            foreach (var item in elements)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
