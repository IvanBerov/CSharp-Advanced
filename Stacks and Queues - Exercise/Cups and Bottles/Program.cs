using System;
using System.Collections.Generic;
using System.Linq;

namespace Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] filledBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> bottles = new Stack<int>(filledBottles);
            Queue<int> cups = new Queue<int>(cupsCapacity);
            int wastedWater = 0;

            while (!(bottles.Count == 0) && !(cups.Count == 0))
            {
                int currCup = cups.Peek();
                int currBottle = bottles.Peek();

                if (currCup > currBottle)
                {
                    int reducedCup = currCup - currBottle;
                    bottles.Pop();

                    while (reducedCup > 0 && bottles.Count != 0)
                    {
                        int nextBottle = bottles.Peek();

                        if (nextBottle > reducedCup)
                        {
                            wastedWater += (nextBottle - reducedCup);          //there are wastedWater
                            reducedCup -= nextBottle;
                        }
                        else
                        {
                            reducedCup -= nextBottle;                         // reducedCupValue <= 0 and there aren't wastedWater
                        }

                        bottles.Pop();

                    }
                    cups.Dequeue();
                }
                else if (currCup <= currBottle)
                {
                    wastedWater += (currBottle - currCup);
                    cups.Dequeue();
                    bottles.Pop();
                }
                
            }

            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ",bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ",cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
    }
}
