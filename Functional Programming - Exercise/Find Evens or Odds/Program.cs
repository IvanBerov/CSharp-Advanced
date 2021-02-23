using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int start = range[0];
            int end = range[1];

            string criteria = Console.ReadLine();

            Func<int, int, List<int>> rangeOfNumbers = (s, e) =>
                  {
                      List<int> nums = new List<int>();
                      for (int i = s; i <= e; i++)
                      {
                          nums.Add(i);
                      }
                      return nums;
                  };

            List<int> numbers = rangeOfNumbers(start, end);

            Predicate<int> predicate = n => true;

            if (criteria == "odd")
            {
                predicate = n => n % 2 != 0;
            }
            else
            {
                predicate = n => n % 2 == 0;
            }

            Console.WriteLine(string.Join(" ",MyWhere(numbers,predicate))); 
        }

        public static List<int> MyWhere(List<int> numbers,Predicate<int> predicate)
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
