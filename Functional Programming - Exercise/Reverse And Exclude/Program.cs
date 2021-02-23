using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Reverse()
                .ToList();

            int n = int.Parse(Console.ReadLine());

            Predicate<int> predicate = num => num % n != 0;
            numbers = MyWhere(numbers, predicate);

            Action<List<int>> print = nums => 
            Console.WriteLine(string.Join(" ",nums));
            print(numbers);

            //Console.WriteLine("----------");

            //numbers = numbers
            //    .Where(x => x % n != 0)
            //    .ToList();

            //Console.WriteLine(string.Join(" ",numbers));
        }
        public static List<int> MyWhere(List<int> numbers, Predicate<int> predicate)
        {
            List<int> newNum = new List<int>();

            foreach (var currNum in numbers)
            {
                if (predicate(currNum))
                {
                    newNum.Add(currNum);
                }
            }
            return newNum;
        }
    }
}
