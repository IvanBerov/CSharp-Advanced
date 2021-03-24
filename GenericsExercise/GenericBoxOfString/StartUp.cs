using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //List<Box<string>> boxes = new List<Box<string>>();
            List<Box<int>> boxes = new List<Box<int>>();

            for (int i = 0; i < n; i++)
            {
                //Box<string> box = new Box<string>(Console.ReadLine());
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));    
                boxes.Add(box);
            }

            int[] index = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            SwapIndexes(boxes,index[0],index[1]);

            foreach (Box<int> currBox in boxes) //ore Box<int>
            {
                Console.WriteLine(currBox);
            }
        }

        public static void SwapIndexes<T>(List<Box<T>> boxes, int firsIndex, int secondIndex)
        {
            Box<T> temp = boxes[firsIndex];
            boxes[firsIndex] = boxes[secondIndex];
            boxes[secondIndex] = temp;
        }
    }
}
