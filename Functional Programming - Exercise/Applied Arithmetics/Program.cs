using System;
using System.Collections.Generic;
using System.Linq;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, Func<int, int>> aritmeticFunction =
            //    new Dictionary<string, Func<int, int>>()
            //    {
            //        {"add",num => num+1 },
            //        {"multiply",num => num*2 },
            //        {"subtract",num => num-1 }
            //    };

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            Func<int, int> aritmeticFunc = num => num;

            Action<List<int>> print =
                num => Console.WriteLine(string.Join(" ", num));

            while (command != "end")
            {
                //if (aritmeticFunction.ContainsKey(command))
                //{
                //    Func<int, int> func = aritmeticFunction[command];
                //    numbers = numbers.Select(func).ToList();
                //}
                //else if (command == "print")
                //{
                //    print(numbers);
                //}

                switch (command)
                {
                    case "add":
                        aritmeticFunc = num => num + 1;
                        numbers = numbers.Select(aritmeticFunc).ToList();
                        break;
                    case "multiply":
                        aritmeticFunc = num => num * 2;
                        numbers = numbers.Select(aritmeticFunc).ToList();
                        break;
                    case "subtract":
                        aritmeticFunc = num => num - 1;
                        numbers = numbers.Select(aritmeticFunc).ToList();
                        break;
                    case "print":
                        print(numbers);
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
