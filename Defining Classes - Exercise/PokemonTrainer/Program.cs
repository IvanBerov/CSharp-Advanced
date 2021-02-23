using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            string input = Console.ReadLine();

            while (input != "Tournament")   // getting input
            {
                string[] tokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string trainerName = tokens[0];

                if (tokens.Length > 3)
                {
                    string pokemonName = tokens[1];
                    string pokemonElement = tokens[2];
                    double pokemonHealth = 0;

                    bool isDouble = double.TryParse(tokens[3], out pokemonHealth);

                    Pokemon newPokemon;

                    if (trainers.All(x => x.Name != trainerName))
                    {
                        Trainer newTrainer = new Trainer(trainerName);

                        newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                        newTrainer.Pokemons.Add(newPokemon);
                        trainers.Add(newTrainer);
                    }
                    else
                    {
                        newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                        var trainer = trainers.Find(x => x.Name == trainerName);

                        trainer.Pokemons.Add(newPokemon);
                    }
                }
                input = Console.ReadLine();
            }

            string elementInput = Console.ReadLine();

            while (elementInput != "End")
            {
                if (elementInput == "Fire" || elementInput == "Water" || elementInput == "Electricity")
                {
                    foreach (var trainer in trainers)
                    {
                        bool hasGivenElement = trainer.Pokemons.Any(x => x.Element == elementInput);

                        if (hasGivenElement)
                        {
                            trainer.AddToBadge();
                        }
                        else
                        {
                            trainer.AttackPokemons();
                        }

                        if (trainer.Pokemons.Count > 0)
                        {
                            trainer.Pokemons.RemoveAll(x => x.Health <= 0);
                        }
                    }
                }
                elementInput = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.GetBadges()))
            {
                Console.Write($"{trainer.Name} {trainer.GetBadges()} {trainer.Pokemons.Count}");
                Console.WriteLine();
            }
        }
    }
}
