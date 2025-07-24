using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Pokedex.Infrastructure.Models.DTOs
{
    public class PokemonApiListDto
    {
        [JsonPropertyName("pokemon_species")]
        public List<PokemonApiDto> PokemonEspecies { get; set; }
    }
}
 