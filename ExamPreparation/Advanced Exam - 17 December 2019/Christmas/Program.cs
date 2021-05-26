using System;
using System.Collections.Generic;
using System.Linq;

namespace Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> materialCrafting = new Stack<int>(input1);
            Queue<int> magicLevelValues = new Queue<int>(input2);

            Dictionary<int, string> presentsMagicLevel = new Dictionary<int, string>
            {
                {150,"Doll" },
                {250,"Wooden train" },
                {300,"Teddy bear" },
                {400,"Bicycle" }
            };
            Dictionary<string, int> presentsMade = new Dictionary<string, int>();

            while (materialCrafting.Count > 0 && magicLevelValues.Count > 0)
            {
                int magicLevel = materialCrafting.Peek() * magicLevelValues.Peek();

                if (presentsMagicLevel.ContainsKey(magicLevel))
                {
                    if (!presentsMade.ContainsKey(presentsMagicLevel[magicLevel]))
                    {
                        presentsMade.Add(presentsMagicLevel[magicLevel], 0);
                    }

                    presentsMade[presentsMagicLevel[magicLevel]]++;

                    materialCrafting.Pop();
                    magicLevelValues.Dequeue();
                }
                else
                {
                    if (magicLevel < 0)
                    {
                        int sum = materialCrafting.Peek() + magicLevelValues.Peek();
                        materialCrafting.Pop();
                        magicLevelValues.Dequeue();
                        materialCrafting.Push(sum);
                    }
                    else if (magicLevel > 0)
                    {
                        int material = materialCrafting.Peek() + 15;
                        materialCrafting.Pop();
                        magicLevelValues.Dequeue();
                        materialCrafting.Push(material);
                    }
                    else if (magicLevel == 0)
                    {
                        if (materialCrafting.Peek() == 0)
                        {
                            materialCrafting.Pop();
                        }
                        if (magicLevelValues.Peek() == 0)
                        {
                            magicLevelValues.Dequeue();
                        }
                    }
                }
            }

            if    ((presentsMade.ContainsKey("Doll") && presentsMade.ContainsKey("Wooden train")) 
                  || (presentsMade.ContainsKey("Teddy bear") && presentsMade.ContainsKey("Bicycle")))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }
            if (materialCrafting.Count > 0)
            {
                Console.WriteLine("Materials left: " + String.Join(", ",materialCrafting));
            }
            if (magicLevelValues.Count > 0)
            {
                Console.WriteLine("Magic left: " + String.Join(", ",magicLevelValues));
            }

            foreach (var presents in presentsMade.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{presents.Key}: {presents.Value}");
            }
        }
    }
}
