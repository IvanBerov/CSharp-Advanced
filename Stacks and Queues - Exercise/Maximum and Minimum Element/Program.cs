using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < N ; i++)
            {
                int[] queries = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int command = queries[0];
                

                if (command == 1)
                {
                    int number = queries[1];
                    numbers.Push(number);
                }
                else if (command == 2)
                {
                    if (numbers.Count != 0)
                    {
                        numbers.Pop();
                    }
                }
                else if (command == 3)
                {
                    if (numbers.Count != 0)
                    {
                        Console.WriteLine(numbers.Max());
                    }
                }
                else
                {
                    if (numbers.Count != 0)
                    {
                        Console.WriteLine(numbers.Min());
                    }
                }
            }
            if (numbers.Count != 0)
            {
                Console.WriteLine(String.Join(", ",numbers));
            }
        }
    }
}
