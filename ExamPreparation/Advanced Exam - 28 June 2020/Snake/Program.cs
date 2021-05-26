using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int snakeRow = -1;
            int snakeCol = -1;
            int firsBurrowRow = -1;
            int firsBurrowCol = -1;
            int secondBurrowRow = -1;
            int secondBurrowCol = -1;

            for (int row = 0; row < n; row++)
            {
                string line = Console.ReadLine();

                for (int col = 0; col < line.Length; col++)
                {
                    matrix[row, col] = line[col];

                    if (matrix[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                    if (matrix[row,col] == 'B')
                    {
                        if (firsBurrowRow == -1)
                        {
                            firsBurrowRow = row;
                            firsBurrowCol = col;
                        }
                        else
                        {
                            secondBurrowRow = row;
                            secondBurrowCol = col;
                        }
                    }
                }
            }

            matrix[snakeRow, snakeCol] = '.';

            int foodCount = 0;

            while (true)
            {
                if (foodCount >= 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    matrix[snakeRow, snakeCol] = 'S';
                    break;
                }

                string command = Console.ReadLine();

                if (command == "up")
                {
                    snakeRow--;
                }
                if (command == "down")
                {
                    snakeRow++;
                }
                if (command == "left")
                {
                    snakeCol--;
                }
                if (command == "right")
                {
                    snakeCol++;
                }

                if (!IsSafePosition(matrix, snakeRow, snakeCol))
                {
                    Console.WriteLine("Game over!");
                    break;
                }
                if (matrix[snakeRow, snakeCol] == '*')
                {
                    foodCount++;
                }
                if (matrix[snakeRow,snakeCol] == 'B')
                {
                    matrix[snakeRow, snakeCol] = '.';

                    if (firsBurrowRow == snakeRow 
                     && firsBurrowCol == snakeCol) // if we are on the firs Burrow
                    {                              // we set it to second Burrow      
                        snakeRow = secondBurrowRow;
                        snakeCol = secondBurrowCol;
                    }
                    else
                    {
                        snakeRow = firsBurrowRow;
                        snakeCol = firsBurrowCol;
                    }
                }
                matrix[snakeRow, snakeCol] = '.';
                //Print(matrix);
            }

            Console.WriteLine($"Food eaten: {foodCount}");
            Print(matrix);

        }
        static void Print(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        static bool IsSafePosition(char[,] matrix, int row, int col)
        {
            if (row < 0 || col < 0)
            {
                return false;
            }
            if (row >= matrix.GetLength(0) ||
                col >= matrix.GetLength(1))
            {
                return false;
            }
            return true;
        }
    }
}

