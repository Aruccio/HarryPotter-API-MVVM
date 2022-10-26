using AutoMapper;
using HarryPotter.Infrastructure.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.MainApplication.Services
{
    public class CharacterRepository : ICharacterRepository
    {
        private HttpClient _httpClient;
        private string _api = "https://hp-api.herokuapp.com/api";
        private string _apiAllCharacters = "/characters";

        public CharacterRepository()
        {
            _httpClient = new HttpClient();

        }

        public async Task<ICollection<Character>> GetAllCharacters()
        {
            var response = await _httpClient.GetAsync($"{_api}{_apiAllCharacters}");
            string allCharacters = response.Content.ReadAsStringAsync().Result;
            var allCharactersJson = JsonConvert.DeserializeObject<ICollection<Character>>(allCharacters);

            return allCharactersJson;
        }

    }
}