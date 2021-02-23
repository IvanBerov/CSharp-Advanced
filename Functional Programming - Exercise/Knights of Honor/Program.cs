using System;
using System.Collections.Generic;
using System.Linq;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(" ")
                .ToList();

            List<string> newNames = names
                .Select(name => $"Sir {name}")
                .ToList();

            Action<List<string>> print = n => Console.WriteLine(string.Join(Environment.NewLine, n));

            print(newNames);
        }
    }
}
