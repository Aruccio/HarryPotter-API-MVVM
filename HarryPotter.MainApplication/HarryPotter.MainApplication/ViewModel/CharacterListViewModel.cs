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
using System.Windows.Input;

namespace HarryPotter.MainApplication.ViewModel
{
    public class CharacterListViewModel
    {
        private ICharacterRepository _repository = new CharacterRepository();

        public CharacterListViewModel()
        {
            AddToFavCommand = new RelayCommand(OnAdd, CanAdd);
            DeleteCommand = new RelayCommand(OnDelete, CanDelete);
            LoadAllCharacters();

        }

        public RelayCommand AddToFavCommand { get; private set; }
        public RelayCommand DeleteCommand { get; private set; }

        private ObservableCollection<Character> allCharacters = new ObservableCollection<Character>();
        private Character selectedCharacter;
        private ObservableCollection<Character> favouriteCharacters = new ObservableCollection<Character>();

        public ObservableCollection<Character> AllCharacters
        {
            get { return allCharacters; }
            set { allCharacters = value; }
        }

        public ObservableCollection<Character> FavouriteCharacters
        {
            get { return favouriteCharacters; }
            set { favouriteCharacters = value; }
        }

        public async void LoadAllCharacters()
        {
            var chars = await _repository.GetAllCharacters();

            foreach (var character in chars)
            {
                allCharacters.Add(character);
            }
        }

        public Character SelectedCharacter
        {
            get => selectedCharacter;
            set 
            { 
                selectedCharacter = value;
                DeleteCommand.RaiseCanExecuteChanged();
                AddToFavCommand.RaiseCanExecuteChanged();
            }
        }

        private void OnAdd()
        {
            FavouriteCharacters.Add(SelectedCharacter);
        }

        private void OnDelete()
        {
            AllCharacters.Remove(SelectedCharacter);
        }

        private bool CanAdd()
        {
            return SelectedCharacter != null;
        }

        private bool CanDelete()
        {
            return SelectedCharacter != null;
        }

    }
}