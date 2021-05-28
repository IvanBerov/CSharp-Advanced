using System;
using System.Collections.Generic;
using System.Linq;

namespace Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstBox = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondBox = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(firstBox);
            Stack<int> stack = new Stack<int>(secondBox);

            List<int> claimedItems = new List<int>();

            while (queue.Any() && stack.Any())
            {
                var firstNumber = queue.Peek();
                var secondNumber = stack.Peek();

                var sum = firstNumber + secondNumber;

                if (sum % 2 == 0)
                {
                    claimedItems.Add(sum);
                    queue.Dequeue();
                    stack.Pop();
                }
                else
                {
                    queue.Enqueue(secondNumber);
                    stack.Pop();
                }
            }

            if (!queue.Any())
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }

            var totalSum = claimedItems.Sum();

            if (totalSum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {totalSum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {totalSum}");
            }
        }
    }
}
