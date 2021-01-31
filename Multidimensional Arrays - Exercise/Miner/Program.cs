using System;
using System.Collections.Generic;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[][] matrix = new char[n][];

            var command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int coals = 0;

            List<int> coordinates = new List<int>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                matrix[row] = new char[matrix.GetLength(0)];

                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    if (input[col] == 'c')
                    {
                        coals++;
                    }
                    if (input[col] == 's')           // начална точка
                    {                                  // запазваме кординати
                        coordinates.Add(row);
                        coordinates.Add(col);
                    }
                    matrix[row][col] = input[col]; // добавяме звезда('*') , 'e' , 'c' ; 's'
                }
            }
            if (coals == 0)
            {
                Console.WriteLine($"You collected all coals! ({coordinates[0]}, {coordinates[1]})");
                return;
            }
            MinerDirection(matrix, command, coordinates, coals);
        }
        static void MinerDirection(char[][] matrix, string[] command, List<int> coordinates, int coals)
        {
            int row = coordinates[0];
            int col = coordinates[1];

            for (int i = 0; i < command.Length; i++)
            {
                var direction = command[i];

                if (direction == "up")
                {
                    if (row - 1 >= 0)
                    {
                        if (matrix[row - 1][col] == 'c')
                        {
                            matrix[row - 1][col] = '*';
                            coals--;
                        }
                        else if (matrix[row - 1][col] == 'e')
                        {
                            Console.WriteLine($"Game over! ({row - 1}, {col})");
                            return;
                        }
                        row--;
                    }
                }
                else if (direction == "down")
                {
                    if (row + 1 < matrix.GetLength(0))
                    {
                        if (matrix[row + 1][col] == 'c')
                        {
                            matrix[row + 1][col] = '*';
                            coals--;
                        }
                        else if (matrix[row + 1][col] == 'e')
                        {
                            Console.WriteLine($"Game over! ({row + 1}, {col})");
                            return;
                        }
                        row++;
                    }

                }
                else if (direction == "left")
                {
                    if (col - 1 >= 0)
                    {
                        if (matrix[row][col - 1] == 'c')
                        {
                            matrix[row][col - 1] = '*';
                            coals--;
                        }
                        else if (matrix[row][col - 1] == 'e')
                        {
                            Console.WriteLine($"Game over! ({row}, {col - 1})");
                            return;
                        }
                        col--;
                    }
                }
                else if (direction == "right")
                {
                    if (col + 1 < matrix.GetLength(0))
                    {
                        if (matrix[row][col + 1] == 'c')
                        {
                            matrix[row][col + 1] = '*';
                            coals--;
                        }
                        else if (matrix[row][col + 1] == 'e')
                        {
                            Console.WriteLine($"Game over! ({row}, {col + 1})");
                            return;
                        }
                        col++;
                    }
                }
                if (coals == 0)
                {
                    Console.WriteLine($"You collected all coals! ({row}, {col})");
                    return;
                }
            }
            Console.WriteLine($"{coals} coals left. ({row}, {col})");
        }
    }
}
