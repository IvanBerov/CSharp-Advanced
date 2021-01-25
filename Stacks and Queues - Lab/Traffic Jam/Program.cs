﻿using System;
using System.Collections.Generic;

namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int count = 0;

            while (true)
            {
                string car = Console.ReadLine();

                if (car == "end")
                {
                    break;
                }
                else if (car == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine(cars.Dequeue() + " passed!");
                            count++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(car);
                }
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
