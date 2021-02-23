using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        private int badgesNum;

        public Trainer(string name)
        {
            this.Name = name;
            badgesNum = 0;
            Pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public void AddToBadge()
        {
            badgesNum += 1;
        }

        public int GetBadges()
        {
            return badgesNum;
        }

        public void AttackPokemons()
        {
            Pokemons.Select(x =>
            {
                x.Health -= 10;
                return x;
            }).ToList();
        }
    }
}
