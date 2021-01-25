using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = input[0];
            int s = input[1];
            int x = input[2];

            Queue<int> num = new Queue<int>();

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < n; i++)
            {
                num.Enqueue(numbers[i]);
            }
            for (int i = 0; i < s; i++)
            {
                num.Dequeue();
            }

            bool isFound = num.Contains(x);

            if (isFound)
            {
                Console.WriteLine("true");
            }
            else if (num.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(num.Min());
            }
        }
    }
}
