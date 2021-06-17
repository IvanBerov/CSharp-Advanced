using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split(" ");
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

                persons.Add(new Person(name, age, town));

                input = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine());
            int matches = 0;
            int notEqual = 0;

            Person person = persons[n - 1];

            foreach (var currPerson in persons)
            {
                var result = person.CompareTo(currPerson);

                if (result < 0)
                {
                    notEqual++;
                }
                else if (result > 0)
                {
                    notEqual++;
                }
                else
                {
                    matches++;
                }
            }

            if (matches <= 1)
            {
                Console.WriteLine($"No matches");
            }
            else
            {
                Console.WriteLine($"{matches} {notEqual} {persons.Count}");
            }
        }
    }
}
