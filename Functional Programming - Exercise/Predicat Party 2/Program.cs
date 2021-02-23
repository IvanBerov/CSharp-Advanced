using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicat_Party_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            string command;

            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] tokens = command.Split(" ").ToArray();
                string type = tokens[0];

                string[] predicatArgs = tokens.Skip(1).ToArray();

                Predicate<string> predicate = GetPredicate(predicatArgs);

                if (type == "Remove")
                {
                    names.RemoveAll(predicate);
                }
                else if (type == "Double")
                {
                    DoubleGuests(names, predicate);
                }
            }
            if (names.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ",names)} are going to the party!");
            }
        }
        public static void DoubleGuests(List<string> names,
                                        Predicate<string> predicate)
        {
            for (int i = 0; i < names.Count; i++)
            {
                string currGuest = names[i];
                if (predicate(currGuest))
                {
                    names.Insert(i + 1, currGuest);
                    i++;
                }
            }
        }
        public static Predicate<string> GetPredicate(string[] predicateArgs)
        {
            string predType = predicateArgs[0];
            string predArgs = predicateArgs[1];

            Predicate<string> predicate = null;

            if (predType == "StartsWith")
            {
                predicate = new Predicate<string>
                    (name =>
                    {
                        return name.StartsWith(predArgs);
                    });
            }
            else if (predType == "EndsWith")
            {
                predicate = new Predicate<string>
                    (neme =>
                    {
                        return neme.EndsWith(predArgs);
                    });
            }
            else if (predType == "Length")
            {
                predicate = new Predicate<string>
                    (name =>
                    {
                        return name.Length == int.Parse(predArgs);
                    });
            }
            return predicate;
        }
    }
}
