using System;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] pascal = new long[n][];

            for (int row = 0; row < n; row++)
            {
                pascal[row] = new long[row + 1];

                for (int col = 0; col < row + 1; col++)
                {
                    long sum = 0;

                    if (row - 1 >= 0 && col < pascal[row - 1].Length )
                    {
                        sum += pascal[row - 1][col];
                    }

                    if (row - 1 >= 0 && col - 1 >= 0)
                    {
                        sum += pascal[row - 1][col - 1];
                    }

                    if (sum == 0)
                    {
                        sum = 1;
                    }

                    pascal[row][col] = sum;
                }
            }

            for (int row = 0; row < pascal.Length; row++)
            {
                for (int col = 0; col < pascal[row].Length ; col++)
                {
                    Console.Write(pascal[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
            //int no_row, c = 1, blk, i, j;

            //Console.Write("\n\n");
            //Console.Write("Display the Pascal's triangle:\n");
            //Console.Write("--------------------------------");
            //Console.Write("\n\n");

            //Console.Write("Input number of rows: ");
            //no_row = Convert.ToInt32(Console.ReadLine());
            //for (i = 0; i < no_row; i++)
            //{
            //    for (blk = 1; blk <= no_row - i; blk++)
            //        Console.Write("  ");
            //    for (j = 0; j <= i; j++)
            //    {
            //        if (j == 0 || i == 0)
            //            c = 1;
            //        else
            //            c = c * (i - j + 1) / j;
            //        Console.Write("{0}   ", c);
            //    }
            //    Console.Write("\n");
            //}
