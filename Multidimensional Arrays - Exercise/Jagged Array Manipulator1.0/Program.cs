using System;
using System.Linq;

namespace Jagged_Array_Manipulator1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsNum = int.Parse(Console.ReadLine());

            double[][] jaggedArray = new double[rowsNum][];

            //Populating the jagged array's rows with integers input sequences from the console
            for (int row = 0; row < rowsNum; row++)
            {
                double[] intSequenceInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                jaggedArray[row] = intSequenceInput;
            }


            //Analyzing the array
            for (int row = 0; row < jaggedArray.Length - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                    }

                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {
                        jaggedArray[row + 1][col] /= 2;
                    }
                }
            }

            //Perform manipulations
            while (true)
            {
                string[] commands = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = commands[0];

                if (command == "End")
                {
                    PrintJaggedArray(jaggedArray);
                    break;
                }
                else
                {
                    int row = int.Parse(commands[1]);
                    int col = int.Parse(commands[2]);
                    double value = double.Parse(commands[3]);

                    switch (command)
                    {
                        case "Add":
                            Add(jaggedArray, row, col, value);
                            break;
                        case "Subtract":
                            Subtract(jaggedArray, row, col, value);
                            break;
                        default:
                            break;
                    }
                }
            }

        }

        private static void Add(double[][] jaggedArray, int row, int col, double
        value)
        {
            if (jaggedArray.Length > row && row >= 0 && col >= 0)
            {
                if (jaggedArray[row].Length > col)
                {
                    jaggedArray[row][col] += value;
                }
            }
        }

        private static void Subtract(double[][] jaggedArray, int row, int col, double
            value)
        {
            if (jaggedArray.Length > row && row >= 0 && col >= 0)
            {
                if (jaggedArray[row].Length > col)
                {
                    jaggedArray[row][col] -= value;
                }
            }
        }

        private static void PrintJaggedArray(double[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
