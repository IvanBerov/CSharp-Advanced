using System;
using System.Linq;

namespace Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] input = Console.ReadLine().ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }

            }
            char symbol = char.Parse(Console.ReadLine());
            bool isFound = false;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (symbol == matrix[row, col])
                    {
                        isFound = true;
                        Console.WriteLine($"({row}, {col})");
                        break; ;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}