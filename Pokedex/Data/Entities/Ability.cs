using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Data.Entities
{
    public class Ability
    {
        [JsonProperty(PropertyName = "Ability Id")]
        public int AbilityId { get; set; }
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        [NotMapped]
        [JsonIgnore]
        public ICollection<PokemonAbility> PokemonAbilities { get; set; }
    }
}
