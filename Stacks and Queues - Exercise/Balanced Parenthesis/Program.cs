using System;
using System.Collections.Generic;

namespace Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> parenthesis = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char parentheses = input[i];

                switch (parentheses)
                {
                    case '{':
                        parenthesis.Push('{');
                        break;
                    case '[':
                        parenthesis.Push('[');
                        break;
                    case '(':
                        parenthesis.Push('(');
                        break;
                    case '}':
                        if (parenthesis.Count > 0)
                        {
                            char currentSymbol = parenthesis.Pop();
                            if (currentSymbol != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    case ']':
                        if (parenthesis.Count > 0)
                        {
                            char currentSymbol = parenthesis.Pop();
                            if (currentSymbol != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    case ')':
                        if (parenthesis.Count > 0)
                        {
                            char currentSymbol = parenthesis.Pop();
                            if (currentSymbol != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    default:
                        break;
                }
            }

            if (parenthesis.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
