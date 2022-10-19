using AutoMapper;
using HarryPotter.Infrastructure.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.MainApplication.Services
{
    public class CharacterService : ICharacterService
    {
        private HttpClient _httpClient;
        private string _api = "https://legacy--api.herokuapp.com/api/v1";
        private string _apiAllCharacters = "/characters";

        public CharacterService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ICollection<Character>> GetAllCharactersFromHogwart()
        {
            var response = await _httpClient.GetAsync($"{_api}{_apiAllCharacters}");
            string allCharacters = response.Content.ReadAsStringAsync().Result;
            var allCharactersJson = JsonConvert.DeserializeObject<List<Character>>(allCharacters);

            return allCharactersJson;
        }

        public async Task<Character> GetCharacterByName(string id)
        {
            var response = await _httpClient.GetAsync($"{_api}{_apiAllCharacters}/{id}");
            string character = response.Content.ReadAsStringAsync().Result;
            var characterJson = JsonConvert.DeserializeObject<Character>(character);

            return characterJson;
        }
    }
}