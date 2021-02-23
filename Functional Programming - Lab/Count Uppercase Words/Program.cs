using System;
using System.Linq;

namespace Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> func = n => n[0] == n.ToUpper()[0];

            string[] text = Console.ReadLine()
                .Split(new string[] { " " },StringSplitOptions.RemoveEmptyEntries)
                .Where(func)
                .ToArray();

            foreach (var word in text)
            {
                Console.WriteLine(word);
            }
        }
    }
}
