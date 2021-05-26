using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bombEffects = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] bombCasing = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(bombCasing);
            Queue<int> queue = new Queue<int>(bombEffects);

            int datura = 0;
            int cherry = 0;
            int smokeDecoy = 0;

            while (true)
            {
                int currBombEffect = queue.Peek();
                int currBombCasing = stack.Peek();
                int sum = currBombCasing + currBombEffect;

                if (sum == 40)
                {
                    datura++;
                    queue.Dequeue();
                    stack.Pop();
                }
                else if (sum == 60)
                {
                    cherry++;
                    queue.Dequeue();
                    stack.Pop();
                }
                else if (sum == 120)
                {
                    smokeDecoy++;
                    queue.Dequeue();
                    stack.Pop();
                }
                else
                {
                    sum -= 5;

                    while (true)
                    {
                        if (sum == 40)
                        {
                            datura++;
                            queue.Dequeue();
                            stack.Pop();
                            break;
                        }
                        else if (sum == 60)
                        {
                            cherry++;
                            queue.Dequeue();
                            stack.Pop();
                            break;
                        }
                        else if (sum == 120)
                        {
                            smokeDecoy++;
                            queue.Dequeue();
                            stack.Pop();
                            break;
                        }
                        else
                        {
                            sum -= 5;
                        }

                    }

                }
                if (queue.Count == 0 ||
                    stack.Count == 0 ||
                    (datura >= 3 && cherry >= 3 && smokeDecoy >= 3))
                {
                    break;
                }
            }
            if (datura >= 3 && cherry >= 3 && smokeDecoy >= 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", queue)} ");
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", stack)}");
            }
            Console.WriteLine($"Cherry Bombs: {cherry}");
            Console.WriteLine($"Datura Bombs: {datura}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoy}");
        }
    }
}
