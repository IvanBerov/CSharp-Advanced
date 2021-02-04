using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestPass = new Dictionary<string, string>();

            SortedDictionary<string, Dictionary<string, int>> nameContestPoints = new SortedDictionary<string, Dictionary<string, int>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] commandArgs = input.Split(':');
                string contest = commandArgs[0];
                string password = commandArgs[1];
                contestPass.Add(contest, password);
            }

            string command = string.Empty;
            string[] separator = { "=>" };

            while ((command = Console.ReadLine()) != "end of submissions")
            {
                string[] commArgs = command.Split(separator, StringSplitOptions.None);

                string contestCheck = commArgs[0];
                string passCheck = commArgs[1];
                string nameCheck = commArgs[2];
                int points = int.Parse(commArgs[3]);


                if (contestPass.ContainsKey(contestCheck)
                    && contestPass.ContainsValue(passCheck))
                {
                    if (nameContestPoints.ContainsKey(nameCheck) == false)
                    {
                        nameContestPoints.Add(nameCheck, new Dictionary<string, int>());
                        nameContestPoints[nameCheck].Add(contestCheck, points);
                    }
                    if (nameContestPoints[nameCheck].ContainsKey(contestCheck))
                    {
                        if (nameContestPoints[nameCheck][contestCheck] < points)
                        {
                            nameContestPoints[nameCheck][contestCheck] = points;
                        }
                    }
                    else
                    {
                        nameContestPoints[nameCheck].Add(contestCheck, points);
                    }
                }
            }

            Dictionary<string, int> usernameTotalPoints = new Dictionary<string, int>();

            foreach (var kvp in nameContestPoints)
            {
                usernameTotalPoints[kvp.Key] = kvp.Value.Values.Sum();
            }

            string bestName = usernameTotalPoints.Keys.Max();
            int bestPoints = usernameTotalPoints.Values.Max();

            foreach (var pair in usernameTotalPoints)
            {
                if (pair.Value == bestPoints)
                {
                    Console.WriteLine($"Best candidate is {pair.Key} with total {pair.Value} points.");
                }
            }

            Console.WriteLine("Ranking: ");

            foreach (var pair in nameContestPoints)
            {
                Dictionary<string, int> dictionary = pair.Value;

                dictionary = dictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine("{0}", pair.Key);

                foreach (var kvp in dictionary)
                {
                    Console.WriteLine("#  {0} -> {1}", kvp.Key, kvp.Value);
                }
            }
        }
    }
}
