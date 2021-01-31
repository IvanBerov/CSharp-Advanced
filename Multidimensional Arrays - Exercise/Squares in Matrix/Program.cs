using System;
using System.Linq;

namespace Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            char[,] matrix = new char[rows, cols];

            fillMatrix(matrix);

            int count = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    char currElement = matrix[row, col];

                    if (currElement == matrix[row,col + 1] && 
                        currElement == matrix[row + 1,col + 1] && 
                        currElement == matrix[row + 1,col])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
        public static void fillMatrix(char[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                char[] currRow = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = currRow[col];
                }
            }
        }
    }
}
