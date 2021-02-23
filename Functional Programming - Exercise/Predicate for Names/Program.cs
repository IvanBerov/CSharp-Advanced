using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split(" ").ToList();

            Func<string, bool> func = name => name.Length <= n;
            names = names.Where(func).ToList();

            Action<List<string>> action =
                names => Console.WriteLine(string.Join(Environment.NewLine, names));

            action(names);
        }
    }
}
