using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            while (input != "Revision")
            {
                var tokens = input.Split(", ",StringSplitOptions.RemoveEmptyEntries);

                string shopNmae = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!shops.ContainsKey(shopNmae))
                {
                    shops.Add(shopNmae, new Dictionary<string, double>());

                    shops[shopNmae].Add(product, price);
                }
                else
                {
                    if (!shops[shopNmae].ContainsKey(product))
                    {
                        shops[shopNmae].Add(product, price);
                    }
                    else
                    {
                        shops[shopNmae][product] = price;
                    }
                }

                input = Console.ReadLine();
            }

            var sorted = shops.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);


            foreach (var shop in sorted)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
