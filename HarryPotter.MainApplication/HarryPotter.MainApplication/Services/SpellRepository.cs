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
    public class SpellRepository
    {
        private HttpClient _httpClient;
        private string _api = "https://hp-api.herokuapp.com/api";
        private string _apiAllSpells = "/spells";

        public SpellRepository()
        {
            _httpClient=new HttpClient();
        }

        public async Task<ICollection<Spell>> GetAllCharacters()
        {
            var response = await _httpClient.GetAsync($"{_api}{_apiAllSpells}");
            string allSpells = response.Content.ReadAsStringAsync().Result;
            var allSpelljson = JsonConvert.DeserializeObject<ICollection<Spell>>(allSpells);

            return allSpelljson;
        }

    }
}
