using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Data.Entities
{
    public class PokemonMove
    {
        [JsonIgnore]
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
        [JsonIgnore]
        public int MoveId { get; set; }
        public Move Move { get; set; }
    }
}
