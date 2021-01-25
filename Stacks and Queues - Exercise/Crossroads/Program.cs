using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int freeWindowSeconds = int.Parse(Console.ReadLine());

            Queue<string> carsQueue = new Queue<string>();

            int counterCars = 0;

            while (true)
            {
                string car = Console.ReadLine();

                int greenLights = greenLightSeconds;  // Сетваме на началните стоиности
                int passSeconds = freeWindowSeconds;

                if (car == "END")
                {
                    Console.WriteLine($"Everyone is safe.{Environment.NewLine}" +
                        $"{counterCars} total cars passed the crossroads.");
                    return;
                }

                if (car == "green")
                {
                    while (greenLights > 0 && carsQueue.Count != 0) // Ако имаме секунди зелено и някакви коли в опашката
                    {
                        string firstInQueue = carsQueue.Dequeue();
                        greenLights -= firstInQueue.Count(); // От секундите вадим броя на буквите на колата

                        if (greenLights >= 0)
                        {
                            counterCars++;
                        }
                        else
                        {
                            passSeconds += greenLights;

                            if (passSeconds < 0)
                            {
                                Console.WriteLine($"A crash happened!{Environment.NewLine}" +
                                    $"{firstInQueue} was hit at" +
                                    $" {firstInQueue[firstInQueue.Length + passSeconds]}.");
                                return;
                            }
                            counterCars++;
                        }
                    }
                }
                else
                {
                    carsQueue.Enqueue(car);
                }
            }
        }
    }
}
