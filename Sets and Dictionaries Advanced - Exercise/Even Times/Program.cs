using System;
using System.Collections.Generic;
using System.Linq;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Dictionary<double,int> numbers = new Dictionary<double, int>();

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                
                if (!numbers.ContainsKey(num))
                {
                    numbers.Add(num, 0);
                }
                numbers[num]++;
                
            }

            var toPrint = numbers.Where(x => x.Value % 2 == 0).FirstOrDefault();
            Console.WriteLine(toPrint.Key);
            
        }
    }
}
