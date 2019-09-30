using Newtonsoft.Json;
using System.Collections.Generic;

namespace Pokedex.Data.Entities
{
    public class Pokemon
    {
        [JsonProperty(PropertyName = "Pokemon Id")]
        public int PokemonId { get; set; }

        [JsonProperty(PropertyName = "Name")]
        public string  Name { get; set; }

        [JsonProperty(PropertyName = "Height")]
        public int Height { get; set; }

        [JsonProperty(PropertyName = "Weight")]
        public int Weight { get; set; }

        [JsonProperty(PropertyName = "Image Url")]
        public string ImageUrl { get; set; }
        [JsonProperty(PropertyName = "Pokemon Image")]
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://localhost:44358{ImageUrl.Substring(1)}";

        [JsonProperty(PropertyName = "Abilities")]
        public ICollection<PokemonAbility> PokemonAbilities { get; set; }
        [JsonProperty(PropertyName = "Types")]
        public ICollection<PokemonType> PokemonTypes { get; set; }
        [JsonProperty(PropertyName = "Moves")]
        public ICollection<PokemonMove> PokemonMoves { get; set; }
    }
}
