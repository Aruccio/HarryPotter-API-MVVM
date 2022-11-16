using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestowyModul.ViewModels
{
    public class TestowyWidokViewModel : BindableBase
    {
        private string _text = "Hello from TestowyWidokViewModel";

        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        public DelegateCommand ClickCommand { get; private set; }

        public TestowyWidokViewModel()
        {
            ClickCommand = new DelegateCommand(Click, CanClick);
        }

        private void Click()
        {
            Text = "You clicked me";
        }

        private bool CanClick()
        {
            return true;
        }
    }
}