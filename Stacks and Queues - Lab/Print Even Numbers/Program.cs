using System;
using System.Collections.Generic;
using System.Linq;

namespace Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> numbers = new Queue<int>(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                int num = numbers.Peek();

                if (num % 2 == 0)
                {
                    numbers.Enqueue(num);
                    numbers.Dequeue();
                }
                else
                {
                    numbers.Dequeue();
                }
            }
            while (numbers.Count != 1)
            {
                Console.Write(numbers.Dequeue() + ", ");
            }
            Console.Write(numbers.Peek());
        }
    }
}
