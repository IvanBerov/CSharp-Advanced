using System;
using System.Linq;

namespace CustomStack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();

            string commandInput = Console.ReadLine();

            while (commandInput != "END")
            {
                string[] tokens = commandInput
                    .Split(new[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                switch (command)
                {
                    case "Push":

                        foreach (var item in tokens.Skip(1))
                        {
                            myStack.Push(int.Parse(item));
                        }
                        break;

                    case "Pop":

                        if (myStack.Count == 0)
                        {
                            Console.WriteLine("No elements");
                        }
                        else
                        {
                            myStack.Pop();
                        }
                        break;
                }

                commandInput = Console.ReadLine();
            }

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
            
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
