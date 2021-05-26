using System;
using System.Linq;

namespace PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPresents = int.Parse(Console.ReadLine());
            int neighbourhoodSize = int.Parse(Console.ReadLine());

            char[,] hood = new char[neighbourhoodSize, neighbourhoodSize];

            int santaRow = -1;
            int santaCol = -1;
            int niceKidsCounter = 0;

            // fill the matrix
            for (int row = 0; row < neighbourhoodSize; row++)
            {
                var line = Console.ReadLine()
                    .Split()
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < line.Length; col++)
                {
                    hood[row, col] = line[col];

                    if (hood[row, col] == 'S') // place of santa
                    {
                        santaRow = row;
                        santaCol = col;
                    }
                    if (hood[row, col] == 'V')
                    {
                        niceKidsCounter++;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "Christmas morning")
            {
                if (countOfPresents <= 0)
                {
                    Console.WriteLine("Santa ran out of presents!");
                    break;
                }

                hood[santaRow, santaCol] = '-';

                switch (command)
                {
                    case "up":
                        santaRow--;
                        break;
                    case "down":
                        santaRow++;
                        break;
                    case "left":
                        santaCol--;
                        break;
                    case "right":
                        santaCol++;
                        break;
                }

                if (hood[santaRow, santaCol] == 'V')
                {
                    countOfPresents--;
                }
                else if (hood[santaRow, santaCol] == 'C')
                {
                    //left
                    if (hood[santaRow, santaCol - 1] != '-')
                    {
                        countOfPresents--;
                        hood[santaRow, santaCol - 1] = '-';
                    }
                    //right
                    if (hood[santaRow, santaCol + 1] != '-')
                    {
                        countOfPresents--;
                        hood[santaRow, santaCol + 1] = '-';
                    }
                    //up
                    if (hood[santaRow - 1, santaCol] != '-')
                    //  ( hood[santaRow-1,santaCol] == 'X' 
                    //|| hood[santaRow-1,santaCol] == 'V')
                    {
                        countOfPresents--;
                        hood[santaRow - 1, santaCol] = '-';
                    }
                    //down
                    if (hood[santaRow + 1, santaCol] != '-')
                    {
                        countOfPresents--;
                        hood[santaRow + 1, santaCol] = '-';
                    }
                }

                command = Console.ReadLine();
            }

            hood[santaRow, santaCol] = 'S';

            int niceKidsNoPresents = 0;

            for (int row = 0; row <hood.GetLength(0) ; row++)
            {
                for (int col = 0; col < hood.GetLength(1); col++)
                {
                    Console.Write(hood[row,col] + " ");

                    if (hood[row,col] == 'V')
                    {
                        niceKidsNoPresents++;
                    }
                }
                Console.WriteLine();
            }

            if (niceKidsNoPresents == 0)
            {
                Console.WriteLine($"Good job, Santa! {niceKidsCounter} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {niceKidsNoPresents} nice kid/s.");
            }
        }
    }
}
