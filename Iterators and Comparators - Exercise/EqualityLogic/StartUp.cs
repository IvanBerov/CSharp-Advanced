using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SortedSet<Person> sortedPerson = new SortedSet<Person>();

            HashSet<Person> personsSet = new HashSet<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                sortedPerson.Add(new Person(name, age));
                personsSet.Add(new Person(name, age));
            }

            Console.WriteLine(sortedPerson.Count);
            Console.WriteLine(personsSet.Count);
        }
    }
}
