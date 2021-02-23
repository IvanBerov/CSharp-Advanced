using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            Func<List<int>, int> number = n =>
             {
                 int minNum = int.MaxValue;

                 foreach (var num in nums)
                 {
                     if (num < minNum)
                     {
                         minNum = num;
                     }
                 }
                 return minNum;
             };
            int minNumber = number(nums);

            Console.WriteLine(minNumber);
            //Console.WriteLine();
            //Console.WriteLine(number(nums));

        }
    }
}
