using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ");
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<decimal>());
                    students[name].Add(grade);
                }
                else
                {
                    students[name].Add(grade);
                }
            }
            foreach (var item in students)
            {
                var grades = item.Value;
                var average = grades.Average();

                Console.Write($"{item.Key} -> ");

                foreach (var grade in grades)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
