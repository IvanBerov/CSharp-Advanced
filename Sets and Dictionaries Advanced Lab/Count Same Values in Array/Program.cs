using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> dict = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                double num = numbers[i];

                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, 1);
                }
                else
                {
                    dict[num]+=1;
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
