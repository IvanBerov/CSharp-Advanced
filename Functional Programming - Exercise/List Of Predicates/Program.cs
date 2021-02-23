
using System;
using System.Linq;

namespace List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int, int, bool> predicate =
                (num, d) => num % d == 0;

            for (int i = 1; i <= n; i++)
            {
                if (dividers.All(d => predicate(i, d)))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
