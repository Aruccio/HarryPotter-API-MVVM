using HarryPotterPrism.Views;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;

namespace HarryPotterPrism.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
        }

        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

    }
}