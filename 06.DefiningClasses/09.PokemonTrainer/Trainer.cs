using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer;

public class Trainer
{
    public Trainer(string name)
    {
        Name = name;
        Pokemons = new();
    }

    public string Name { get; set; }
    public int NumberOfBadges { get; set; }
    public List<Pokemon> Pokemons { get; set; }

    public void CheckPokemon(string element)
    {
        if (Pokemons.Any(p => p.Element == element))
        {
            NumberOfBadges++;
        }
        else
        {
            for (int i = 0; i < Pokemons.Count; i++)
            {
                Pokemon currentPokemon = Pokemons[i];

                currentPokemon.Health -= 10;

                if (currentPokemon.Health <= 0)
                {
                    Pokemons.Remove(currentPokemon);
                }
            }
        }
    }
}
