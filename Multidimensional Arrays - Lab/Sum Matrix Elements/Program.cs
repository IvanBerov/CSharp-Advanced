using System;
using System.Linq;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split(", ")
                .Select(int.Parse)
                .ToArray();

            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];                   // създаваме матрица

            for (int row = 0; row < rows; row++)                     // пълним матрицата от конзолата
            {
                int[] rowData = Console.ReadLine().Split(", ")
               .Select(int.Parse)
               .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int sum = 0;

            for (int row = 0; row < rows; row++)             // сумираме елементите на матрицата
            {
                for (int col = 0; col < cols; col++)
                {
                    sum += matrix[row, col];

                   // Console.WriteLine(matrix[row,col] + " ");
                }
                //Console.WriteLine();
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
            //int n = int.Parse(Console.ReadLine());

            //var matrix = new int[n, n];

            //for (int row = 0; row < n; row++)
            //{
            //    for (int col = 0; col < n; col++)
            //    {
            //        matrix[row, col] = row + col;
            //    }
            //}

            //for (int row = 0; row < n; row++)
            //{
            //    for (int col = 0; col < n; col++)
            //    {
            //        Console.Write(matrix[row,col] + " ");
            //    }
            //    Console.WriteLine();
            //}
