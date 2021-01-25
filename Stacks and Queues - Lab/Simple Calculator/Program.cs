using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<string> stack = new Stack<string>(input
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Reverse());

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string opr = stack.Pop();
                int second = int.Parse(stack.Pop());

                switch (opr)
                {
                    case "+":
                        stack.Push((first + second).ToString());
                        break;
                    case "-":
                        stack.Push((first - second).ToString());
                        break;
                    default:
                        throw new ArgumentException("Unknown operator");
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
