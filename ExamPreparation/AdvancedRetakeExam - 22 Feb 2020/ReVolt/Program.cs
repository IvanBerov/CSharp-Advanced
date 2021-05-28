using System;

namespace ReVolt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int countCommands = int.Parse(Console.ReadLine());

            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string inputArray = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputArray[col];

                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            bool foundFinish = false;

            for (int i = 0; i < countCommands; i++)
            {
                string command = Console.ReadLine();

                if (command == "up")
                {
                    matrix[playerRow, playerCol] = '-';

                    playerRow--;

                    if (!ValidateInOut(matrix, playerRow, playerCol))
                    {
                        playerRow = n - 1;
                    }
                    else if (matrix[playerRow, playerCol] == 'B')
                    {
                        playerRow--;

                        if (!ValidateInOut(matrix, playerRow, playerCol))
                        {
                            playerRow = n - 1;
                        }
                    }
                    else if (matrix[playerRow, playerCol] == 'T')
                    {
                        playerRow++;
                    }

                    if (matrix[playerRow, playerCol] == 'F')
                    {
                        foundFinish = true;
                        matrix[playerRow, playerCol] = 'f';
                        break;
                    }

                    matrix[playerRow, playerCol] = 'f';
                }
                else if (command == "down")
                {
                    matrix[playerRow, playerCol] = '-';

                    playerRow++;

                    if (!ValidateInOut(matrix, playerRow, playerCol))
                    {
                        playerRow = 0;
                    }
                    else if (matrix[playerRow, playerCol] == 'B')
                    {
                        playerRow++;

                        if (!ValidateInOut(matrix, playerRow, playerCol))
                        {
                            playerRow = 0;
                        }
                    }
                    else if (matrix[playerRow, playerCol] == 'T')
                    {
                        playerRow--;
                    }

                    if (matrix[playerRow, playerCol] == 'F')
                    {
                        foundFinish = true;
                        matrix[playerRow, playerCol] = 'f';
                        break;
                    }

                    matrix[playerRow, playerCol] = 'f';
                }
                else if (command == "left")
                {
                    matrix[playerRow, playerCol] = '-';
                    playerCol--;

                    if (!ValidateInOut(matrix, playerRow, playerCol))
                    {
                        playerCol = n - 1;
                    }
                    else if (matrix[playerRow, playerCol] == 'B')
                    {
                        playerCol--;

                        if (!ValidateInOut(matrix, playerRow, playerCol))
                        {
                            playerCol = n - 1;
                        }
                    }
                    else if (matrix[playerRow, playerCol] == 'T')
                    {
                        playerCol++;
                    }

                    if (matrix[playerRow, playerCol] == 'F')
                    {
                        foundFinish = true;
                        matrix[playerRow, playerCol] = 'f';
                        break;
                    }

                    matrix[playerRow, playerCol] = 'f';
                }
                else if (command == "right")
                {
                    matrix[playerRow, playerCol] = '-';
                    playerCol++;

                    if (!ValidateInOut(matrix, playerRow, playerCol))
                    {
                        playerCol = 0;
                    }
                    else if (matrix[playerRow, playerCol] == 'B')
                    {
                        playerCol++;

                        if (!ValidateInOut(matrix, playerRow, playerCol))
                        {
                            playerCol = 0;
                        }
                    }
                    else if (matrix[playerRow, playerCol] == 'T')
                    {
                        playerCol--;
                    }

                    if (matrix[playerRow, playerCol] == 'F')
                    {
                        foundFinish = true;
                        matrix[playerRow, playerCol] = 'f';
                        break;
                    }

                    matrix[playerRow, playerCol] = 'f';
                }
            }

            if (foundFinish)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
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

        private static bool ValidateInOut(char[,] matrix, int currentRow, int currentCol)
        {
            if (currentRow >= 0 && currentRow < matrix.GetLength(0) && currentCol >= 0 && currentCol < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }
    }
}
