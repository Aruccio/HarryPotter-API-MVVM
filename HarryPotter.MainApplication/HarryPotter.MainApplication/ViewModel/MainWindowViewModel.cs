
using System;
using System.ComponentModel;
using System.Timers;

namespace HarryPotter.MainApplication.ViewModel
{
    public class MainWindowViewModel :INotifyPropertyChanged
    {
        private Timer _timer = new Timer(2000);
        private string _notificationMessage;

        public MainWindowViewModel()
        {
            CurrentViewModel = new CharacterListViewModel();
            _timer.Elapsed += (s, e) =>
            {
                NotificationMessage = "At the tone the time will be: " + DateTime.Now.ToLocalTime() + " beep.";
            };
            _timer.Start();
        }

        public object CurrentViewModel { get; set; }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public string NotificationMessage
        {
            get
            {
                return _notificationMessage;
            }
            set
            {
                if (value != _notificationMessage)
                {
                    _notificationMessage = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("NotificationMessage"));
                }
            }
        }
    }
}