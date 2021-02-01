using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> dict = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ");
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!dict.ContainsKey(continent))
                {
                    dict.Add(continent, new Dictionary<string, List<string>>());
                    dict[continent].Add(country, new List<string>());
                    dict[continent][country].Add(city);
                }
                else
                {
                    if (!dict[continent].ContainsKey(country))
                    {
                        dict[continent].Add(country, new List<string>());
                        dict[continent][country].Add(city);
                    }
                    else
                    {
                        dict[continent][country].Add(city);
                    }
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}:");

                foreach (var pair in item.Value)
                {
                    Console.WriteLine($"{pair.Key} -> {string.Join(", ",pair.Value)}");
                }
            }
        }
    }
}
