using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(numbers);

            int rackCounter = 0;
            int sum = 0;

            while (stack.Count > 0)
            {
                var curr = stack.Peek();

                if (sum+curr > capacity)
                {
                    rackCounter++;
                    sum = 0;
                }
                else if (sum+curr == capacity)
                {
                    rackCounter++;
                    sum = 0;
                    stack.Pop();
                }
                else 
                { 
                   sum += stack.Pop();
                }   
            }
            if (sum > 0)
            {
                rackCounter++;
            }
            Console.WriteLine(rackCounter);
        }
    }
}
