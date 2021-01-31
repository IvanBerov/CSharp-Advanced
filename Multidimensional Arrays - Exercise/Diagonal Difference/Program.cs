using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] numbers = new int[n, n];

            fillMatrix(numbers);

            int sumPrimaryDiagonal = 0;
            int sumSecondaryDiagonal = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int num = numbers[row, col]; // всяко число от марицата

                    if (row == col)
                    {
                        sumPrimaryDiagonal += num;
                    }

                    if (col == n - 1 - row)
                    {
                        sumSecondaryDiagonal += num;
                    }
                }
            }

            Console.WriteLine(Math.Abs(sumPrimaryDiagonal-sumSecondaryDiagonal));

        }

        public static void printMatrix(int[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    Console.Write(numbers[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void fillMatrix(int[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                int[] currRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = currRow[col];
                }
            }
        }
    }
}
