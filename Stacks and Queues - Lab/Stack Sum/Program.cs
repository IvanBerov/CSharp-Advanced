using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToArray();

            Stack<int> stack = new Stack<int>(arr);

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string comm = tokens[0];
                if (comm == "add")
                {
                    int firstNum = int.Parse(tokens[1]);
                    int secondNum = int.Parse(tokens[2]);
                    stack.Push(firstNum);
                    stack.Push(secondNum);

                }
                else if (comm == "remove")
                {
                    int number = int.Parse(tokens[1]);

                    if (stack.Count < number)
                    {
                        command = Console.ReadLine().ToLower();
                        continue;
                    }
                    for (int i = 0; i < number; i++)
                    {
                        stack.Pop();
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            int sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
