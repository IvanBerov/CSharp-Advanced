using System;
using System.Collections.Generic;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stak = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                stak.Push(input[i]);
            }

            while (stak.Count > 0)
            {
                Console.Write(stak.Pop());
            }
        }
    }
}
