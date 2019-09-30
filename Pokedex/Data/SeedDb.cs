using Pokedex.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            if (_context.Pokemons.Any())
            {
                return;   // DB has been seeded
            }

            await CheckPokemonAsync();
        }

        public async Task CheckPokemonAsync()
        {
            if (!_context.Pokemons.Any())
            {

                var bulbasaur = new Pokemon
                {
                    Name = "Bulbasaur",
                    Height = 7,
                    Weight = 68,
                    ImageUrl = $"~/Resources/Images/Bulbasaur.png"
            };

                var charmander = new Pokemon
                {
                    Name = "Charmander",
                    Height = 6,
                    Weight = 85,
                    ImageUrl = $"~/Resources/Images/Charmander.png"
                };

                var squirtle = new Pokemon
                {
                    Name = "Squirtle",
                    Height = 5,
                    Weight = 90,
                    ImageUrl = $"~/Resources/Images/Squirtle.png"
                };


                var ability = new List<Ability>
                {
                    new Ability{Name = "chlorophyll"},
                    new Ability{Name = "overgrow"},
                    new Ability{Name = "solar-power"},
                    new Ability{Name = "blaze"},
                    new Ability{Name = "rain-dish"},
                    new Ability{Name = "Torrent"}
                };

                var type = new List<Entities.Type>
                {
                    new Entities.Type{Name = "grass"},
                    new Entities.Type{Name = "water"},
                    new Entities.Type{Name = "fire"}
                };

                var move = new List<Move>
                {
                    new Move{Name = "razor-wind"},               
                    new Move{Name = "swords-dance"},
                    new Move{Name = "mega-punch"},
                    new Move{Name = "fire-punch"},
                    new Move{Name = "Ice-punch"},
                    new Move{Name = "Mega-Kick"}
                };

                bulbasaur.PokemonAbilities = new List<PokemonAbility>
                {
                    new PokemonAbility{Ability = ability[0],Pokemon = bulbasaur},
                    new PokemonAbility{Ability = ability[1],Pokemon = bulbasaur}
                };

                bulbasaur.PokemonTypes = new List<PokemonType>
                {
                    new PokemonType{Type = type[0],Pokemon = bulbasaur}
                };

                bulbasaur.PokemonMoves = new List<PokemonMove>
                {
                    new PokemonMove{Move = move[0],Pokemon = bulbasaur},
                    new PokemonMove{Move = move[1],Pokemon = bulbasaur}
                };

                charmander.PokemonAbilities = new List<PokemonAbility>
                {
                    new PokemonAbility{Ability = ability[2],Pokemon = charmander},
                    new PokemonAbility{Ability = ability[3],Pokemon = charmander}
                };

                charmander.PokemonTypes = new List<PokemonType>
                {
                    new PokemonType{Type = type[2],Pokemon = charmander}
                };

                charmander.PokemonMoves = new List<PokemonMove>
                {
                    new PokemonMove{Move = move[2],Pokemon = charmander},
                    new PokemonMove{Move = move[3],Pokemon = charmander}
                };

                squirtle.PokemonAbilities = new List<PokemonAbility>
                {
                    new PokemonAbility{Ability = ability[4],Pokemon = squirtle},
                    new PokemonAbility{Ability = ability[5],Pokemon = squirtle}
                };

                squirtle.PokemonTypes = new List<PokemonType>
                {
                    new PokemonType{Type = type[1],Pokemon = squirtle}
                };

                squirtle.PokemonMoves = new List<PokemonMove>
                {
                    new PokemonMove{Move = move[4],Pokemon = squirtle},
                    new PokemonMove{Move = move[2],Pokemon = squirtle},
                    new PokemonMove{Move = move[5],Pokemon = squirtle}
                };



                AddPokemon(bulbasaur , bulbasaur.PokemonAbilities.ToList() , bulbasaur.PokemonTypes.ToList(),
                bulbasaur.PokemonMoves.ToList());

                AddPokemon(charmander, charmander.PokemonAbilities.ToList(), charmander.PokemonTypes.ToList(),
                charmander.PokemonMoves.ToList());

                AddPokemon(squirtle, squirtle.PokemonAbilities.ToList(), squirtle.PokemonTypes.ToList(),
                squirtle.PokemonMoves.ToList());

                await _context.SaveChangesAsync();
            }
        }

        private void AddPokemon(Pokemon pokemon, List<PokemonAbility> pokemonAbilities, 
            List<PokemonType> pokemonTypes, List<PokemonMove> pokemonMoves)
        {
            _context.Pokemons.Add(new Pokemon
            {

                Name = pokemon.Name,
                Height = pokemon.Height,
                Weight = pokemon.Weight,
                ImageUrl = pokemon.ImageUrl,
                PokemonAbilities = pokemonAbilities,
                PokemonTypes = pokemonTypes,
                PokemonMoves = pokemonMoves
            });

        }
    }
}
