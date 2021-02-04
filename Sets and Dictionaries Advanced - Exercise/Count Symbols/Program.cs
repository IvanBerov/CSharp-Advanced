using System;
using System.Collections.Generic;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char currChar = text[i];
                if (!dict.ContainsKey(currChar))
                {
                    dict.Add(currChar, 0);
                }
                dict[currChar]++;
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
