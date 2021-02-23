using System;

namespace DateModifierProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            int days = DateModifier.GetDiffBetweenDatesInDay(firstDate, secondDate);
            Console.WriteLine(days);
        }
    }
}
