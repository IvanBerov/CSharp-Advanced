using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = num[0];
            int m = num[1];

            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            HashSet<int> newSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                first.Add(input);
            }
            for (int i = 0; i < m; i++)
            {
                int input = int.Parse(Console.ReadLine());
                second.Add(input);
            }

            foreach (var item in first)
            {
                foreach (var kvp in second)
                {
                    if (item == kvp)
                    {
                        newSet.Add(item);
                    }
                }
            }
            foreach (var item in newSet)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
