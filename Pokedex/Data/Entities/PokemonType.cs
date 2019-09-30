using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Data.Entities
{
    public class PokemonType
    {
        [JsonIgnore]
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
        [JsonIgnore]
        public int TypeId { get; set; }
        public Type Type { get; set; }
    }
}
