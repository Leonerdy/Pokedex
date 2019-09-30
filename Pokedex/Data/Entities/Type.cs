using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Data.Entities
{
    public class Type
    {
        [JsonProperty(PropertyName = "Type Id")]
        public int TypeId { get; set; }
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        [JsonIgnore]
        public ICollection<PokemonType> PokemonTypes { get; set; }

        
        
    }
}
