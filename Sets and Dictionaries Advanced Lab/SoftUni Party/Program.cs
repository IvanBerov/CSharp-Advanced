using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();

            while (true)
            {
                string commands = Console.ReadLine();

                if (commands == "PARTY")
                {
                    break;
                }
                guests.Add(commands);
            }
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                if (guests.Contains(input))
                {
                    guests.Remove(input);
                }
            }

            Console.WriteLine(guests.Count);

            foreach (var item in guests)
            {
                char[] ch = item.ToCharArray();
                if (char.IsDigit(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }
            foreach (var item in guests)
            {
                char[] ch = item.ToCharArray();
                if (char.IsLetter(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
