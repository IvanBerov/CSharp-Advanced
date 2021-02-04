using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];
                string[] item = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!dict.ContainsKey(color))
                {
                    dict.Add(color, new Dictionary<string, int>());
                    for (int j = 0; j < item.Length; j++)
                    {
                        string currItem = item[j];

                        if (dict[color].ContainsKey(currItem))
                        {
                            dict[color][currItem]++;
                            continue;
                        }
                        dict[color].Add(currItem, 1);
                    }
                }
                else
                {
                    for (int k = 0; k < item.Length; k++)
                    {
                        string currItem = item[k];

                        if (dict[color].ContainsKey(currItem))
                        {
                            dict[color][currItem]++;
                            continue;
                        }
                        dict[color].Add(currItem, 1);
                    }
                }

            }
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string colorToFind = command[0];
            string clothing = command[1];

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var cloths in kvp.Value)
                {
                    if (kvp.Key == colorToFind && cloths.Key == clothing)
                    {
                        Console.WriteLine($"* {cloths.Key} - {cloths.Value} (found!)");
                        continue;
                    }

                    Console.WriteLine($"* {cloths.Key} - {cloths.Value}");
                }
            }
        }
    }
}
