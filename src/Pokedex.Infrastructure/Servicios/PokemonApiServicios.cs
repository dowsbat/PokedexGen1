using Pokedex.Application.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Net.Http;
using Pokedex.Infrastructure.Models.DTOs;

namespace Pokedex.Infrastructure.Servicios
{
    public class PokemonApiServicios : IPokemonApiServicios
    {
        private readonly HttpClient _httpClient;

        public PokemonApiServicios(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient.CreateClient("PokemonApi");
        }


        public async Task<IEnumerable<string>> GetFirstGenPokemon()
        {
            // Implementación de la lógica para obtener los Pokémon de la primera generación
            var response = await _httpClient.GetFromJsonAsync<PokemonApiListDto>("generation/1");
            return response?.PokemonEspecies.Select(p => p.Name)?? new List<string>();
           
        }
    }


}
