using System;
using ConsoleApp2.Entity;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp2.Repository
{
    public class PokemonRepository: IPokemonRepository
    {
        public async Task<List<Pokemon>> GetPokemons()
        {
            var url = "https://pokeapi.co/api/v2/pokemon/";
            var options = new JsonSerializerOptions { WriteIndented = true,PropertyNameCaseInsensitive = true };
            List<Pokemon> listPokemons = new List<Pokemon>();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    PokemonRes pokemons = System.Text.Json.JsonSerializer.Deserialize<PokemonRes>(content, options);
                    listPokemons = pokemons.results;

                }
            }
            return listPokemons;
        }
        public async Task<List<Pokemon>> GetPokeItems()
        {
            var url = "https://pokeapi.co/api/v2/item/";
            var options = new JsonSerializerOptions { WriteIndented = true,PropertyNameCaseInsensitive = true };
            List<Pokemon> listPokeItems = new List<Pokemon>();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    PokemonRes pokeItems = System.Text.Json.JsonSerializer.Deserialize<PokemonRes>(content, options);
                    listPokeItems = pokeItems.results;

                }
            }
            return listPokeItems;
        }
    }
}