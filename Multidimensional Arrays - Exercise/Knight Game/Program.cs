using System;

namespace Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] chessBoard = new char[n, n];

            fillMatrix(chessBoard);

            int countReplaced = 0;
            int rowKill = 0;
            int colKill = 0;

            while (true)
            {
                int maxAttacs = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char currSymbol = chessBoard[row, col];
                        int countAttacs = 0;

                        if (currSymbol == 'K')
                        {
                            countAttacs = 
                                GetAttacks(chessBoard,
                                row, col, countAttacs);

                            if (countAttacs > maxAttacs)
                            {
                                maxAttacs = countAttacs;
                                rowKill = row;
                                colKill = col;
                            }
                        }
                    }
                }

                if (maxAttacs > 0)
                {
                    chessBoard[rowKill, colKill] = '0';
                    countReplaced++;
                }
                else
                {
                    Console.WriteLine(countReplaced);
                    break;
                }

                if (maxAttacs <= 0)
                {
                    Console.WriteLine(countReplaced);
                    break;
                }
            }
           // printMatrix(chessBoard);
        }
        private static int GetAttacks(char[,] chessBoard, int row, int col, int countAttacs)
        {
            if (IsIside(chessBoard, row - 2, col + 1) &&
                chessBoard[row - 2, col + 1] == 'K')
            {
                countAttacs++;
            }

            if (IsIside(chessBoard, row - 2, col - 1) &&
                chessBoard[row - 2, col - 1] == 'K')
            {
                countAttacs++;
            }

            if (IsIside(chessBoard, row + 1, col + 2) &&
                chessBoard[row + 1, col + 2] == 'K')
            {
                countAttacs++;
            }

            if (IsIside(chessBoard, row + 1, col - 2) &&
                chessBoard[row + 1, col - 2] == 'K')
            {
                countAttacs++;
            }

            if (IsIside(chessBoard, row - 1, col + 2) &&
                chessBoard[row - 1, col + 2] == 'K')
            {
                countAttacs++;
            }

            if (IsIside(chessBoard, row - 1, col - 2) &&
                chessBoard[row - 1, col - 2] == 'K')
            {
                countAttacs++;
            }

            if (IsIside(chessBoard, row + 2, col - 1) &&
                chessBoard[row + 2, col - 1] == 'K')
            {
                countAttacs++;
            }

            if (IsIside(chessBoard, row + 2, col + 1) &&
                chessBoard[row + 2, col + 1] == 'K')
            {
                countAttacs++;
            }

            return countAttacs;
        }

        public static void fillMatrix(char[,] lethers)
        {
            for (int row = 0; row < lethers.GetLength(0); row++)
            {
                char[] currRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < lethers.GetLength(1); col++)
                {
                    lethers[row, col] = currRow[col];
                }
            }
        }
        //public static void printMatrix(char[,] matrix)
        //{
        //    for (int row = 0; row < matrix.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < matrix.GetLength(1); col++)
        //        {
        //            Console.Write(matrix[row, col]);
        //        }
        //        Console.WriteLine();
        //    }
        //}
        public static bool IsIside(char[,] chassBord, int targetRow, int targetCol)
        {
            return targetRow >= 0 &&
                   targetRow < chassBord.GetLength(0) &&
                   targetCol >= 0 &&
                   targetCol < chassBord.GetLength(1);
        }
    }
}
