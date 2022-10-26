using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.MainApplication.ViewModel
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            CurrentViewModel = new CharacterListViewModel();
        }

        public object CurrentViewModel { get; set; }

    }
}