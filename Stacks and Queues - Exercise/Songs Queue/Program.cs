using System;
using System.Collections.Generic;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>(songs);
            string command = Console.ReadLine();

            while (queue.Count > 0)
            {
                if (command.Contains("Play"))
                {
                    queue.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    var songToAdd = command.Split("Add ",StringSplitOptions.RemoveEmptyEntries);

                    if (queue.Contains(songToAdd[0]))
                    {
                        Console.WriteLine($"{songToAdd[0]} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(songToAdd[0]);
                    }
                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(String.Join(", ", queue));
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
