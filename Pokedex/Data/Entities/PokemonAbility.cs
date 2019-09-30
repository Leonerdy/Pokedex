using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Data.Entities
{
    public class PokemonAbility
    {
        [JsonIgnore]
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
        [JsonIgnore]
        public int AbilityId { get; set; }
        public Ability Ability { get; set; }
    }
}
