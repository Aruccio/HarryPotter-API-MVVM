using HarryPotter.Infrastructure.Model;
using HarryPotter.MainApplication.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.MainApplication.ViewModel
{
    public class CharacterListViewModel
    {
        private ICharacterRepository _repository = new CharacterRepository();

        public CharacterListViewModel()
        {
            LoadCharacters();
        }

        private ObservableCollection<Character> characters = new ObservableCollection<Character>();
        public ObservableCollection<Character> Characters
        {
            get { return characters; }
            set { characters = value; }
        }

        public async void LoadCharacters()
        {
            var chars = await _repository.GetAllCharacters();

            foreach (var character in chars)
            {
                characters.Add(character);
            }
        }
    }
}