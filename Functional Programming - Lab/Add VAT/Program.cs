using System;
using System.Linq;

namespace Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] price = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < price.Length; i++)
            {
                Console.WriteLine($"{(price[i] * 1.20):f2}");
            }
        }
    }
}
