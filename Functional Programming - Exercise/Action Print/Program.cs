using System;
using System.Collections.Generic;
using System.Linq;

namespace Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(" ")
                .ToList();

            Action<List<string>> action = name => Console.WriteLine(string.Join(Environment.NewLine, name));

            action(names);
        }
    }
}
