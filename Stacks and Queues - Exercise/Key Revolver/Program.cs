using System;
using System.Collections.Generic;
using System.Linq;

namespace Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());

            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int intelligenceValue = int.Parse(Console.ReadLine());

            Queue<int> locksQueue = new Queue<int>(locks);

            Stack<int> bulletStack = new Stack<int>(bullets);

            int count = 0;
            int currBarrelSize = gunBarrelSize;

            while (locksQueue.Any() && bulletStack.Any())
            {

                count++;
                currBarrelSize--;
                int currBullet = bulletStack.Pop();
                int currLock = locksQueue.Peek();

                if (currBullet <= currLock)
                {
                    Console.WriteLine("Bang!");
                    locksQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (currBarrelSize == 0 && bulletStack.Any())
                {
                    currBarrelSize = gunBarrelSize;
                    Console.WriteLine("Reloading!");
                }
            }

            if (!locksQueue.Any())
            {
                int money = intelligenceValue - (count * bulletPrice);
                Console.WriteLine($"{bulletStack.Count} bullets left. Earned ${money}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
        }
    }
}
