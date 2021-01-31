using System;
using System.Linq;

namespace Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jagged = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                jagged[row] = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
            }

            Analyze(jagged);

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                int targetRow = int.Parse(tokens[1]);
                int targetCol = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (!IsInside(jagged,targetRow,targetCol))
                {
                    continue;
                }

                if (tokens[0] == "Add")
                {
                    jagged[targetRow][targetCol] += value;
                }
                else
                {
                    jagged[targetRow][targetCol] -= value;
                }

                command = Console.ReadLine();
            }

            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ",item));
            }
        }
        // ппроверка за масива , дали е вътре :)
        public static bool IsInside(double[][] jagged, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < jagged.Length
                && targetCol >= 0 && targetCol < jagged[targetRow].Length;
        }

        public static void Analyze(double[][] jagged)
        {
            for (int row = 0; row < jagged.Length - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length) 
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;
                    }

                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {
                        jagged[row + 1][col] /= 2;
                    }
                }
            }
        }
    }
}
