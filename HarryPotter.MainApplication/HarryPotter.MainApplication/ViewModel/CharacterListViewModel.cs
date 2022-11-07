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
    public class CharacterListViewModel : INotifyPropertyChanged
    {
        private ICharacterRepository _repository = new CharacterRepository();
        public RelayCommand AddToFavCommand { get; private set; }
        public RelayCommand DeleteCommand { get; private set; }

        private ObservableCollection<Character> _allCharacters = new ObservableCollection<Character>();
        private Character _selectedCharacter;
        private ObservableCollection<Character> _favouriteCharacters = new ObservableCollection<Character>();

        public event PropertyChangedEventHandler? PropertyChanged = delegate { };

        public CharacterListViewModel()
        {
            AddToFavCommand = new RelayCommand(OnAdd, CanAdd);
            DeleteCommand = new RelayCommand(OnDelete, CanDelete);
            //LoadAllCharacters();
        }



        public ObservableCollection<Character> AllCharacters
        {
            get { return _allCharacters; }
            set
            {
                _allCharacters = value;
                if (_allCharacters != value)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("AllCharacters"));
                }
            }
        }

        public ObservableCollection<Character> FavouriteCharacters
        {
            get { return _favouriteCharacters; }
            set { _favouriteCharacters = value; }
        }

        public async void LoadAllCharacters()
        {
            var chars = await _repository.GetAllCharacters();

            foreach (var character in chars)
            {
                _allCharacters.Add(character);
            }
        }

        public Character SelectedCharacter
        {
            get => _selectedCharacter;
            set 
            {
                _selectedCharacter = value;
                if (_selectedCharacter!=null)
                {
                    DeleteCommand.RaiseCanExecuteChanged();
                    AddToFavCommand.RaiseCanExecuteChanged();
                    PropertyChanged(this, new PropertyChangedEventArgs("SelectedCharacter"));

                }
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